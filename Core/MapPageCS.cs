﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace FormsBackgrounding
{
	public class Route
	{
		public TimeSpan time { get; set; }
		public CustomMap customMap { get; set; }
	}


	public class MapPageCS : ContentPage
	{
		public MapPageCS()
		{
			var customMap = new CustomMap
			{
				MapType = MapType.Street,
				WidthRequest = App.ScreenWidth,
				HeightRequest = App.ScreenHeight
			};

			customMap.RouteCoordinates.Add(new Position(37.797534, -122.401827));
			customMap.RouteCoordinates.Add(new Position(37.797510, -122.402060));
			customMap.RouteCoordinates.Add(new Position(37.790269, -122.400589));
			customMap.RouteCoordinates.Add(new Position(37.790265, -122.400474));
			customMap.RouteCoordinates.Add(new Position(37.790228, -122.400391));
			customMap.RouteCoordinates.Add(new Position(37.790126, -122.400360));
			customMap.RouteCoordinates.Add(new Position(37.789250, -122.401451));
			customMap.RouteCoordinates.Add(new Position(37.788440, -122.400396));
			customMap.RouteCoordinates.Add(new Position(37.787999, -122.399780));
			customMap.RouteCoordinates.Add(new Position(37.786736, -122.398202));
			customMap.RouteCoordinates.Add(new Position(37.786345, -122.397722));
			customMap.RouteCoordinates.Add(new Position(37.785983, -122.397295));
			customMap.RouteCoordinates.Add(new Position(37.785559, -122.396728));
			customMap.RouteCoordinates.Add(new Position(37.780624, -122.390541));
			customMap.RouteCoordinates.Add(new Position(37.777113, -122.394983));
			customMap.RouteCoordinates.Add(new Position(37.776831, -122.394627));

			customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));
			Content = customMap;
		}


		public void LogRoute()
		{
			// Keeps adding positions to the route log
		}

		public void StartLoggingRoute()
		{
			// Starts Tracking Route
		}

		public void EndLoggingRoute()
		{
			//Saves all the positions into the DB

			//Shows the final information screen for a run
		}

		public void UpdateRouteSummary()
		{
			// Update the route summary information like distance travelled and time taken and pace
		}

		public void CalculateDistance(List<Position> route)
		{
			// Run through the positions and calculate distance
		}

		public TimeSpan CalculatePace(List<Position> route, TimeSpan time)
		{
			TimeSpan pace = new TimeSpan();

			// Take everything from route - calculate the distance
			// Calculate pace by going distance / time

			return pace;
		}

		public void StoreSplits()
		{
			// Get pace from CalculatePace

			// Store it in list of route splits
		}

	}
}

