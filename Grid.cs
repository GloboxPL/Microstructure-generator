using System;
using System.Drawing;
using static System.Math;
using System.Collections.Generic;
using System.Linq;

namespace ZCA3
{
	class Grid
	{
		private Cell[,] grid;
		private readonly int xSize;
		private readonly int ySize;
		public bool Periodic { get; private set; }
		public bool Generated { get; private set; }
		public bool EnergyGenerated { get; private set; }
		private Random random = new Random();

		public Grid(int xSize, int ySize, bool periodic)
		{
			Cell.ResetCells();
			grid = new Cell[xSize, ySize];
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < ySize; j++)
				{
					grid[i, j] = new Cell();
				}
			}
			this.xSize = xSize;
			this.ySize = ySize;
			Periodic = periodic;
			Generated = false;
			EnergyGenerated = false;
		}

		public bool Nucleation(int row, int column) //jednorodne
		{
			if (row > xSize / 2 || column > ySize / 2)
			{
				throw new Exception("Zbyt duża ilość zarodków!");
			}
			double x = 0;
			double y = 0;
			double dx = xSize / row;
			double dy = ySize / column;
			int px = (int)(xSize - dx * (row - 1)) / 2;
			int py = (int)(ySize - dy * (column - 1)) / 2;
			for (int id = 1; id <= row * column; id++)
			{
				grid[(int)x + px, (int)y + py].SetId(id);
				x += dx;
				if (id % row == 0)
				{
					x = 0;
					y += dy;
				}
			}
			return true;
		}

		public bool Nucleation(float radius, int amount) //losowe z promieniem
		{
			int failureCount = 0;
			int d = (int)Ceiling(radius);
			for (int id = 1; id <= amount; id++)
			{
				int x = random.Next(xSize);
				int y = random.Next(ySize);
				bool t = true;
				for (int i = x - d; i < x + d; i++)
				{
					for (int j = y - d; j < y + d; j++)
					{
						if (!Periodic)
						{
							if (IsOutside(i, j))
							{
								continue;
							}
						}
						if (DistanceWithOffset(x, y, i, j) <= radius && grid[BoarderX(i), BoarderY(j)].Id != 0)
						{
							t = false;
							id--;
							failureCount++;
							break;
						}
					}
					if (!t)
					{
						break;
					}
				}
				if (t)
				{
					failureCount = 0;
					grid[x, y].SetId(id);
				}
				else if (failureCount >= 1000)
				{
					throw new Exception($"Nie udało się wylosować zadanej ilości zarodków.\nWylosowano {id} zarodków.");
				}
			}
			return true;
		}

		public bool Nucleation(int amount) //losowe
		{
			int failureCount = 0;
			for (int id = 1; id <= amount; id++)
			{
				int x = random.Next(xSize);
				int y = random.Next(ySize);
				if (grid[x, y].Id == 0)
				{
					failureCount = 0;
					grid[x, y].SetId(id);
				}
				else
				{
					id--;
					failureCount++;
				}
				if (failureCount >= 1000)
				{
					throw new Exception($"Nie udało się wylosować zadanej ilości zarodków.\nWylosowano {id} zarodków.");
				}
			}
			return true;
		}

		public int UpdatCellIdToNextTimetep(string neighborhood, int x, int y, float radius)
		{
			if (grid[x, y].Id != 0)
			{
				return grid[x, y].Id;
			}
			int id = 0;
			switch (neighborhood)
			{
				case "von neumann":
					id = VonNeumannNeighborhood(x, y);
					break;
				case "moore":
					id = MooreNeighborhood(x, y);
					break;
				case "pentagonal":
					id = PentagonalNeighborhood(x, y);
					break;
				case "hexagonal right":
					id = HexagonalNeighborhood(x, y, "right");
					break;
				case "hexagonal left":
					id = HexagonalNeighborhood(x, y, "left");
					break;
				case "hexagonal random":
					id = HexagonalNeighborhood(x, y);
					break;
				case "radius":
					id = RadiusNeighborhood(x, y, radius, false);
					break;
				case "offset radius":
					id = RadiusNeighborhood(x, y, radius, true);
					break;
			}
			return id;
		}

		private int RadiusNeighborhood(int x, int y, float radius, bool offset)
		{
			Dictionary<int, int> neighbors = new Dictionary<int, int>();
			int id = 0;
			int d = (int)Ceiling(radius);
			float distance;
			for (int i = x - d; i < x + d; i++)
			{
				for (int j = y - d; j < y + d; j++)
				{
					if (!Periodic)
					{
						if (IsOutside(i, j))
						{
							continue;
						}
					}
					if (offset)
					{
						distance = DistanceWithOffset(x, y, i, j);
					}
					else
					{
						distance = Distance(x, y, i, j);
					}
					if (distance <= radius)
					{
						id = grid[BoarderX(i), BoarderY(j)].Id;
						if (id == 0)
						{
							continue;
						}
						if (neighbors.ContainsKey(id))
						{
							neighbors[id]++;
						}
						else
						{
							neighbors.Add(id, 1);
						}
					}
				}
			}
			if (neighbors.Count == 0)
			{
				return 0;
			}
			int max = neighbors.Values.Max();
			foreach (var item in neighbors)
			{
				if (item.Value == max)
				{
					id = item.Key;
				}
			}
			return id;
		}

		private int HexagonalNeighborhood(int x, int y, string type = "random")
		{
			Dictionary<int, int> neighbors = new Dictionary<int, int>(8);
			int id = 0;
			for (int i = x - 1; i <= x + 1; i++)
			{
				for (int j = y - 1; j <= y + 1; j++)
				{
					if (!Periodic)
					{
						if (IsOutside(i, j))
						{
							continue;
						}
					}
					if (i == x && j == y)
					{
						continue;
					}
					if (type == "random")
					{
						if (random.Next(2) == 0)
						{
							type = "left";
						}
						else
						{
							type = "right";
						}
					}
					switch (type)
					{
						case "left":
							if ((i == x - 1 && j == y - 1) || (i == x + 1 && j == y + 1))
							{
								continue;
							}
							break;
						case "right":
							if ((i == x - 1 && j == y + 1) || (i == x + 1 && j == y - 1))
							{
								continue;
							}
							break;
					}
					id = grid[BoarderX(i), BoarderY(j)].Id;
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			if (neighbors.Count == 0)
			{
				return 0;
			}
			int max = neighbors.Values.Max();
			foreach (var item in neighbors)
			{
				if (item.Value == max)
				{
					id = item.Key;
				}
			}
			return id;
		}

		private int PentagonalNeighborhood(int x, int y)
		{
			int r = random.Next(4);
			int xS = 0, xE = 0, yS = 0, yE = 0;
			switch (r)
			{
				case 0:
					xS = 1;
					break;
				case 1:
					xE = 1;
					break;
				case 2:
					yS = 1;
					break;
				case 3:
					yE = 1;
					break;
			}
			Dictionary<int, int> neighbors = new Dictionary<int, int>(5);
			int id = 0;
			for (int i = x - 1 + xS; i <= x + 1 - xE; i++)
			{
				for (int j = y - 1 + yS; j <= y + 1 - yE; j++)
				{
					if (!Periodic)
					{
						if (IsOutside(i, j))
						{
							continue;
						}
					}
					if (i == x && j == y)
					{
						continue;
					}
					id = grid[BoarderX(i), BoarderY(j)].Id;
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			if (neighbors.Count == 0)
			{
				return 0;
			}
			int max = neighbors.Values.Max();
			foreach (var item in neighbors)
			{
				if (item.Value == max)
				{
					id = item.Key;
				}
			}
			return id;
		}

		private int MooreNeighborhood(int x, int y)
		{
			Dictionary<int, int> neighbors = new Dictionary<int, int>(8);
			int id = 0;
			for (int i = x - 1; i <= x + 1; i++)
			{
				for (int j = y - 1; j <= y + 1; j++)
				{
					if (!Periodic)
					{
						if (IsOutside(i, j))
						{
							continue;
						}
					}
					if (i == x && j == y)
					{
						continue;
					}
					id = grid[BoarderX(i), BoarderY(j)].Id;
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			if (neighbors.Count == 0)
			{
				return 0;
			}
			int max = neighbors.Values.Max();
			foreach (var item in neighbors)
			{
				if (item.Value == max)
				{
					id = item.Key;
				}
			}
			return id;
		}

		private int VonNeumannNeighborhood(int x, int y)
		{
			Dictionary<int, int> neighbors = new Dictionary<int, int>(4);
			int id = 0;
			if (Periodic)
			{
				for (int i = 0; i < 4; i++)
				{
					switch (i)
					{
						case 0:
							id = grid[BoarderX(x - 1), BoarderY(y)].Id;
							break;
						case 1:
							id = grid[BoarderX(x), BoarderY(y + 1)].Id;
							break;
						case 2:
							id = grid[BoarderX(x + 1), BoarderY(y)].Id;
							break;
						case 3:
							id = grid[BoarderX(x), BoarderY(y - 1)].Id;
							break;
					}
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			else
			{
				for (int i = 0; i < 4; i++)
				{
					if (IsOutside(x - 1, y) && i == 0)
					{
						continue;
					}
					if (IsOutside(x, y + 1) && i == 1)
					{
						continue;
					}
					if (IsOutside(x + 1, y) && i == 2)
					{
						continue;
					}
					if (IsOutside(x, y - 1) && i == 3)
					{
						continue;
					}
					switch (i)
					{
						case 0:
							id = grid[x - 1, y].Id;
							break;
						case 1:
							id = grid[x, y + 1].Id;
							break;
						case 2:
							id = grid[x + 1, y].Id;
							break;
						case 3:
							id = grid[x, y - 1].Id;
							break;
					}
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			if (neighbors.Count == 0)
			{
				return 0;
			}
			int max = neighbors.Values.Max();
			foreach (var item in neighbors)
			{
				if (item.Value == max)
				{
					id = item.Key;
				}
			}
			return id;
		}

		public void GenerateNextTimestep(string neighborhood, float radius = 0)
		{
			Generated = true;
			Cell[,] newGrid = new Cell[xSize, ySize];
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < ySize; j++)
				{
					if (grid[i, j].Id == 0)
					{
						Generated = false;
					}
					newGrid[i, j] = new Cell(UpdatCellIdToNextTimetep(neighborhood, i, j, radius));
				}
			}
			grid = newGrid;
		}

		public void ChangeColor(int x, int y)
		{
			grid[x, y].SetId();
		}

		private int BoarderX(int x)
		{
			if (x < 0)
			{
				return xSize + x;
			}
			else
			{
				return x % xSize;
			}
		}

		private int BoarderY(int y)
		{
			if (y < 0)
			{
				return ySize + y;
			}
			else
			{
				return y % ySize;
			}
		}

		private bool IsOutside(int x, int y)
		{
			if (x < 0 || x >= xSize || y < 0 || y >= ySize)
			{
				return true;
			}
			return false;
		}

		private float DistanceWithOffset(int x1, int y1, int x2, int y2)
		{
			float dx = Abs((x1 + grid[BoarderX(x1), BoarderY(y1)].OffsetX) - (x2 + grid[BoarderX(x2), BoarderY(y2)].OffsetX));
			float dy = Abs((y1 + grid[BoarderX(x1), BoarderY(y1)].OffsetY) - (y2 + grid[BoarderX(x2), BoarderY(y2)].OffsetY));
			return (float)Sqrt(Pow(dx, 2) + Pow(dy, 2));
		}

		private float Distance(int x1, int y1, int x2, int y2)
		{
			float dx = Abs(x1 - x2);
			float dy = Abs(y1 - y2);
			return (float)Sqrt(Pow(dx, 2) + Pow(dy, 2));
		}

		public bool IsContainNucleation()
		{
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < ySize; j++)
				{
					if (grid[i, j].Id != 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		public Bitmap GetRealSizeBitmap()
		{
			Bitmap bitmap = new Bitmap(xSize, ySize);
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < ySize; j++)
				{
					bitmap.SetPixel(i, j, grid[i, j].GetColor());
				}
			}
			return bitmap;
		}

		public Bitmap GetResizedBitmap(int pictureBoxWidth, int pictureBoxHeight)
		{
			int scale;
			if (ySize >= xSize)
			{
				scale = pictureBoxHeight / ySize;
			}
			else
			{
				scale = pictureBoxWidth / xSize;
			}
			if (scale == 0 || scale == 1)
			{
				return GetRealSizeBitmap();
			}
			Bitmap bitmap = new Bitmap(scale * xSize, scale * ySize);
			Graphics graphics = Graphics.FromImage(bitmap);
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < ySize; j++)
				{
					graphics.FillRectangle(new SolidBrush(grid[i, j].GetColor()), i * scale, j * scale, scale, scale);
				}
			}
			graphics.Dispose();
			return bitmap;
		}

		public int GetXSize()
		{
			return xSize;
		}

		public int GetYSize()
		{
			return ySize;
		}

		//--------------------------------------Monte Carlo

		private List<Point> ListOfCells()
		{
			List<Point> list = new List<Point>();
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < ySize; j++)
				{
					list.Add(new Point(i, j));
				}
			}
			return list;
		}

		public void GenerateNextMonteCarloTimestep(string neighborhood, double kt, float radius = 0)
		{
			List<Point> list = ListOfCells();
			while (list.Count != 0)
			{
				int i = random.Next(list.Count);
				switch (neighborhood)
				{
					case "von neumann":
						VonNeumannEnergy(list[i].X, list[i].Y, kt);
						break;
					case "moore":
						MooreEnergy(list[i].X, list[i].Y, kt);
						break;
					case "pentagonal":
						PentagonalEnergy(list[i].X, list[i].Y, kt);
						break;
					case "hexagonal right":
						HexagonalEnergy(list[i].X, list[i].Y, kt, "right");
						break;
					case "hexagonal left":
						HexagonalEnergy(list[i].X, list[i].Y, kt, "left");
						break;
					case "hexagonal random":
						HexagonalEnergy(list[i].X, list[i].Y, kt);
						break;
					case "radius":
						RadiusEnergy(list[i].X, list[i].Y, kt, radius, false);
						break;
					case "offset radius":
						RadiusEnergy(list[i].X, list[i].Y, kt, radius, true);
						break;
				}
				list.RemoveAt(i);
			}
			EnergyGenerated = true;
		}

		private void RadiusEnergy(int x, int y, double kt, float radius, bool offset)
		{
			Dictionary<int, int> neighbors = new Dictionary<int, int>();
			int id = 0;
			int d = (int)Ceiling(radius);
			float distance;
			for (int i = x - d; i < x + d; i++)
			{
				for (int j = y - d; j < y + d; j++)
				{
					if (!Periodic)
					{
						if (IsOutside(i, j))
						{
							continue;
						}
					}
					if (offset)
					{
						distance = DistanceWithOffset(x, y, i, j);
					}
					else
					{
						distance = Distance(x, y, i, j);
					}
					if (distance <= radius)
					{
						id = grid[BoarderX(i), BoarderY(j)].Id;
						if (id == 0)
						{
							continue;
						}
						if (neighbors.ContainsKey(id))
						{
							neighbors[id]++;
						}
						else
						{
							neighbors.Add(id, 1);
						}
					}
				}
			}
			int energy;
			grid[x, y].SetId(MinimumEnergyCellId(neighbors, grid[x, y].Id, kt, out energy));
			grid[x, y].Energy = energy;
		}

		private void HexagonalEnergy(int x, int y, double kt, string type = "random")
		{
			Dictionary<int, int> neighbors = new Dictionary<int, int>(8);
			int id = 0;
			for (int i = x - 1; i <= x + 1; i++)
			{
				for (int j = y - 1; j <= y + 1; j++)
				{
					if (!Periodic)
					{
						if (IsOutside(i, j))
						{
							continue;
						}
					}
					if (i == x && j == y)
					{
						continue;
					}
					if (type == "random")
					{
						if (random.Next(2) == 0)
						{
							type = "left";
						}
						else
						{
							type = "right";
						}
					}
					switch (type)
					{
						case "left":
							if ((i == x - 1 && j == y - 1) || (i == x + 1 && j == y + 1))
							{
								continue;
							}
							break;
						case "right":
							if ((i == x - 1 && j == y + 1) || (i == x + 1 && j == y - 1))
							{
								continue;
							}
							break;
					}
					id = grid[BoarderX(i), BoarderY(j)].Id;
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			int energy;
			grid[x, y].SetId(MinimumEnergyCellId(neighbors, grid[x, y].Id, kt, out energy));
			grid[x, y].Energy = energy;
		}

		private void PentagonalEnergy(int x, int y, double kt)
		{
			int r = random.Next(4);
			int xS = 0, xE = 0, yS = 0, yE = 0;
			switch (r)
			{
				case 0:
					xS = 1;
					break;
				case 1:
					xE = 1;
					break;
				case 2:
					yS = 1;
					break;
				case 3:
					yE = 1;
					break;
			}
			Dictionary<int, int> neighbors = new Dictionary<int, int>(5);
			int id = 0;
			for (int i = x - 1 + xS; i <= x + 1 - xE; i++)
			{
				for (int j = y - 1 + yS; j <= y + 1 - yE; j++)
				{
					if (!Periodic)
					{
						if (IsOutside(i, j))
						{
							continue;
						}
					}
					if (i == x && j == y)
					{
						continue;
					}
					id = grid[BoarderX(i), BoarderY(j)].Id;
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			int energy;
			grid[x, y].SetId(MinimumEnergyCellId(neighbors, grid[x, y].Id, kt, out energy));
			grid[x, y].Energy = energy;
		}

		private void MooreEnergy(int x, int y, double kt)
		{
			Dictionary<int, int> neighbors = new Dictionary<int, int>(8);
			int id = 0;
			for (int i = x - 1; i <= x + 1; i++)
			{
				for (int j = y - 1; j <= y + 1; j++)
				{
					if (!Periodic)
					{
						if (IsOutside(i, j))
						{
							continue;
						}
					}
					if (i == x && j == y)
					{
						continue;
					}
					id = grid[BoarderX(i), BoarderY(j)].Id;
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			int energy;
			grid[x, y].SetId(MinimumEnergyCellId(neighbors, grid[x, y].Id, kt, out energy));
			grid[x, y].Energy = energy;
		}

		private void VonNeumannEnergy(int x, int y, double kt)
		{
			Dictionary<int, int> neighbors = new Dictionary<int, int>(4);
			int id = 0;
			if (Periodic)
			{
				for (int i = 0; i < 4; i++)
				{
					switch (i)
					{
						case 0:
							id = grid[BoarderX(x - 1), BoarderY(y)].Id;
							break;
						case 1:
							id = grid[BoarderX(x), BoarderY(y + 1)].Id;
							break;
						case 2:
							id = grid[BoarderX(x + 1), BoarderY(y)].Id;
							break;
						case 3:
							id = grid[BoarderX(x), BoarderY(y - 1)].Id;
							break;
					}
					if (id == 0)
					{
						continue;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			else
			{
				for (int i = 0; i < 4; i++)
				{
					if (IsOutside(x - 1, y) && i == 0)
					{
						continue;
					}
					if (IsOutside(x, y + 1) && i == 1)
					{
						continue;
					}
					if (IsOutside(x + 1, y) && i == 2)
					{
						continue;
					}
					if (IsOutside(x, y - 1) && i == 3)
					{
						continue;
					}
					switch (i)
					{
						case 0:
							id = grid[x - 1, y].Id;
							break;
						case 1:
							id = grid[x, y + 1].Id;
							break;
						case 2:
							id = grid[x + 1, y].Id;
							break;
						case 3:
							id = grid[x, y - 1].Id;
							break;
					}
					if (neighbors.ContainsKey(id))
					{
						neighbors[id]++;
					}
					else
					{
						neighbors.Add(id, 1);
					}
				}
			}
			int energy;
			grid[x, y].SetId(MinimumEnergyCellId(neighbors, grid[x, y].Id, kt, out energy));
			grid[x, y].Energy = energy;
		}

		private int MinimumEnergyCellId(Dictionary<int, int> neighbors, int id, double kt, out int cellEnergy)
		{
			int energy1 = 0;
			int energy2 = 0;
			List<int> list = new List<int>();
			foreach (var item in neighbors)
			{
				list.Add(item.Key);
				if (item.Key != id)
				{
					energy1 += item.Value;
				}
			}
			int tempId = list[random.Next(list.Count)];
			foreach (var item in neighbors)
			{
				if (item.Key != tempId)
				{
					energy2 += item.Value;
				}
			}
			if (IsIdChangeAccepted(energy2 - energy1, kt))
			{
				cellEnergy = energy2;
				return tempId;
			}
			cellEnergy = energy1;
			return id;
		}

		private bool IsIdChangeAccepted(int energyDelta, double kt)
		{
			if (energyDelta <= 0)
			{
				return true;
			}
			else
			{
				double p = Math.Exp(-energyDelta / kt);
				if (p >= random.NextDouble())
				{
					return true;
				}
			}
			return false;
		}

		private int GetMaximumEnergyValue()
		{
			int maximum = 0;
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < ySize; j++)
				{
					if (grid[i, j].Energy > maximum)
					{
						maximum = grid[i, j].Energy;
					}
				}
			}
			return maximum;
		}

		public Bitmap GetResizedBitmapEnergy(int pictureBoxWidth, int pictureBoxHeight)
		{
			int scale;
			double grad = 255 / GetMaximumEnergyValue();
			if (ySize >= xSize)
			{
				scale = pictureBoxHeight / ySize;
			}
			else
			{
				scale = pictureBoxWidth / xSize;
			}
			Bitmap bitmap = new Bitmap(scale * xSize, scale * ySize);
			Graphics graphics = Graphics.FromImage(bitmap);
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < ySize; j++)
				{
					Color color = Color.FromArgb((int)(grid[i, j].Energy * grad), 50, 255 - (int)(grid[i, j].Energy * grad));
					graphics.FillRectangle(new SolidBrush(color), i * scale, j * scale, scale, scale);
				}
			}
			graphics.Dispose();
			return bitmap;
		}
	}
}
