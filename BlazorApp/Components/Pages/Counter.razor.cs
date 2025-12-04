using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp.Components.Pages
{
    public partial class Counter
    {
        [Parameter]
        public int IncrementAmount { get; set; } = 1;

        [Parameter]
        public int InitialValue { get; set; }

        private int currentCount = 0;
        private string text = "";
        private string result = "";
        private string action = "MouseOut";

        protected override void OnInitialized()
        {
            currentCount = InitialValue;
        }
        private async Task Search()
        {
            result = $"Searching...: {text}";
            // Simulate an asynchronous operation
            await Task.Delay(500);
            result = $"{Random.Shared.Next(1, 100)} results found for '{text}'";
        }

        private void IncrementCount()
        {
            currentCount += IncrementAmount;
        }

        private void Clear(MouseEventArgs args)
        {
            text = "";
        }

        private void MouseOver(MouseEventArgs args)
        {
            action = "MouseOver";
        }

        private void MouseOut(MouseEventArgs args)
        {
            action = "MouseOut";
        }
    }
}