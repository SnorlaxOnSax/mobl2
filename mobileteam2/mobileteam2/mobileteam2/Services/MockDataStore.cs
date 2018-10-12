using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mobileteam2.Enums;
using mobileteam2.Models;

namespace mobileteam2.Services
{
    public class MockDataStore : IDataStore<Claim>
    {
        List<Claim> items;

        public MockDataStore()
        {
            items = new List<Claim>();
            var mockItems = new List<Claim>
            {
                new Claim { Id = Guid.NewGuid().ToString(), Number = "HP0008675309", Status = ClaimStatus.Open, Description="Your homeowner's claim.", CurrentStep = TimelineSteps.FirstPaymentsDocsProvided},
                new Claim { Id = Guid.NewGuid().ToString(), Number = "APV001234567", Status = ClaimStatus.Open, Description="Your personal auto claim.", CurrentStep = TimelineSteps.Inspection},
                new Claim { Id = Guid.NewGuid().ToString(), Number = "HP0004444444", Status = ClaimStatus.Open, Description="Your homeowner's claim.", CurrentStep = TimelineSteps.FinalPayment},
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Claim item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Claim item)
        {
            var oldItem = items.Where((Claim arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Claim arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Claim> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Claim>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}