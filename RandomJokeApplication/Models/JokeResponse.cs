using System;

namespace RandomJokeApplication.Models
{
    public class JokeResponse
    {
        // if we were saving these objects to the db
        // adding an Id value here would be necessary
        public string Type { get; set; }
        public string Joke { get; set; }
    }
}