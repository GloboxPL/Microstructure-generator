using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;

namespace ZCA3
{
	[Serializable()]
	class Cell : ISerializable
	{
		private static List<Color> colors;
		public int Id { get; private set; }
		public float OffsetX { get; private set; }
		public float OffsetY { get; private set; }
		public int Energy { get; set; }
		private static Random random = new Random();

		public Cell() //tworzy biala komorke
		{
			Id = 0;
			if (colors == null)
			{
				colors = new List<Color>();
				colors.Add(Color.White);
			}
			//offset z zakresu (-0.5; 0.5), natomiast (0,0) to srodek komorki 
			OffsetX = (float)((random.NextDouble() - 0.5) * 0.999);
			OffsetY = (float)((random.NextDouble() - 0.5) * 0.999);
		}

		public Cell(int id)
		{
			Id = id;
			if (colors.Count == id)
			{
				colors.Add(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
			}
		}
		public void SetId(int id) //ustawia id i kolor komorki
		{
			Id = id;
			if (colors.Count == id)
			{
				colors.Add(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
			}
		}

		public void SetId()
		{
			if (Id == 0)
			{
				SetId(colors.Count);
			}
			else
			{
				Id = 0;
			}
		}

		public Color GetColor()
		{
			return colors[Id];
		}

		public static void ResetCells()
		{
			colors = null;
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("colors", colors);
			info.AddValue("Id", Id);
			info.AddValue("OffsetX", OffsetX);
			info.AddValue("OffsetY", OffsetY);
		}

		public Cell(SerializationInfo info, StreamingContext context)
		{
			colors = (List<Color>)info.GetValue("colors", typeof(List<Color>));
			Id = info.GetInt32("Id");
			OffsetX = info.GetInt32("OffsetX");
			OffsetY = info.GetInt32("OffsetY");
			random = new Random();
		}
	}
}
