﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{

	// *Load the text file
	// *Convert the text to a List<PrizeModel>
	// Find the ID
	// Add the new record with the new ID (max + 1)
	// Convert the prizes to a List<string>
	// Save the List<string> to the text file


	public static class TextConnectorProcessor
	{
		/// <summary>
		/// Adds the file name to the end of the full file path from app settings.
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns>Full file path.</returns>
		public static string FullFilePath(this string fileName) 
		{
			// C:\data\TournamentTracker\PrizeModels.csv
			return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
		}

		public static List<string> LoadFile(this string file)
		{
			if (!File.Exists(file))
			{
				return new List<string>();
			}

			return File.ReadAllLines(file).ToList();
		}

		public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
			List<PrizeModel> output = new List<PrizeModel>();

			foreach(string line in lines)
            {
				string[] cols = line.Split(',');

				PrizeModel p = new PrizeModel();
				p.Id = int.Parse(cols[0]);
				p.PlaceNumber = int.Parse(cols[1]);
				p.PlaceName = cols[2];
				p.PrizeAmount = decimal.Parse(cols[3]);
				p.PrizePercentage = double.Parse(cols[4]);

				output.Add(p);
            }

			return output;
        }

		public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
			List<string> lines = new List<string>();

			foreach(PrizeModel p in models)
            {
				lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");

            }

			File.WriteAllLines(fileName.FullFilePath(), lines);
        }
	}
}
