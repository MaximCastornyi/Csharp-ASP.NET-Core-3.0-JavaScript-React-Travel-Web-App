using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsOrganizerWebApp.Data.Models;

namespace TeamsOrganizerWebApp.Data.Services
{
    public class TripService : ITripService
    {
        public void AddTrip(Trip trip)
        {
            Data.Trips.Add(trip);
        }

        public void DeleteTrip(int tripId)
        {
            var trip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
            if (trip != null)
            {
                Data.Trips.Remove(trip);
            }
        }

        public List<Trip> GetAllTrips() => Data.Trips.ToList();

        public Trip GetTripById(int tripId) => Data.Trips.FirstOrDefault(n => n.Id == tripId);

        public void UpdateTrip(int tripId, Trip trip)
        {
            var oldTrip = Data.Trips.FirstOrDefault(n => n.Id == tripId);

            if (oldTrip != null)
            {
                oldTrip.Name = trip.Name;
                oldTrip.Description = trip.Description;
                oldTrip.DateStarted = trip.DateStarted;
                oldTrip.DateCompleted = trip.DateCompleted;
            }
        }
    }
}