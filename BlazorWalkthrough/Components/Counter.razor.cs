using Microsoft.AspNetCore.Components;

namespace BlazorWalkthrough.Components
{
    public partial class Counter
    {

        [Parameter]
        public int CurrentCount { get; set; } = 0;
        //protected override void OnInitialized()
        //{
        //    CurrentCount = 5;
        //}

       
        private void IncrementCount()
        {
            CurrentCount++;
        }
    }
}