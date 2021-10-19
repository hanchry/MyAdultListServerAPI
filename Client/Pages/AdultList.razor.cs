using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


namespace Client.Pages
{
    public partial class AdultList:ComponentBase
    {
        
        private IList<Adult> allAdults;
        private IList<Adult> toShow;
        

        private string? firstName;
        protected override async Task OnInitializedAsync()
        {
            allAdults = await fileReader.GetAdults();
            toShow = allAdults;
        }
        
        public void FindByName(ChangeEventArgs changeEventArgs)
        {
            firstName = null;
            try
            {
                firstName = changeEventArgs.Value.ToString();
            }
            catch (Exception e)
            {
            }
            ExecuteFilter();
        }

        public void ExecuteFilter()
        {
            toShow = allAdults.Where(adult => (adult.FirstName.Contains(firstName))).ToList();
        }
        
        

        
        
    }
}