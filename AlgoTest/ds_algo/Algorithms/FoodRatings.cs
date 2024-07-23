using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{

    public class FoodRatings
    {
        private string[] _foods;
        private string[] _cuisines;
        private int[] _ratings;
        private Dictionary<string, List<(string, int)>> map;

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            _foods = foods;
            _cuisines = cuisines;
            _ratings = ratings;
            map = new Dictionary<string, List<(string, int)>>();
            CreateGraph(map);
        }

        public void CreateGraph(Dictionary<string, List<(string, int)>> map)
        {
            for (int i = 0; i < _cuisines.Length; i++)
            {
                if (map.ContainsKey(_cuisines[i]))
                    map[_cuisines[i]].Add(new(_foods[i], _ratings[i]));
                else
                    map[_cuisines[i]] = new List<(string, int)>() { new(_foods[i], _ratings[i]) };
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            var index = Array.IndexOf(_foods, food);
            if (index != -1)
            {
                _ratings[index] = newRating;
                UpdateMap(food, _cuisines[index], newRating);
            }
        }

        private void UpdateMap(string food, string cuisine, int newRating)
        {
            if (map.ContainsKey(cuisine))
            {
                var foodEntry = map[cuisine].FirstOrDefault(x => x.Item1 == food);
                if (foodEntry != default)
                {
                    map[cuisine].Remove(foodEntry);
                    map[cuisine].Add(new(food, newRating));
                }
            }
        }

        public string HighestRated(string cuisine)
        {
            if (map.ContainsKey(cuisine) && map[cuisine].Any())
            {
                var highestRatedFood = map[cuisine]
                    .OrderByDescending(x => x.Item2)
                    .ThenBy(x => x.Item1)
                    .FirstOrDefault().Item1;

                if (highestRatedFood != null)
                {
                    int index = Array.IndexOf(_foods, highestRatedFood);
                    return index != -1 ? _foods[index] : null;
                }
            }

            return null;
        }
    }

}

