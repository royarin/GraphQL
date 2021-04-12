using Microsoft.AspNetCore.Components;

namespace BlazorGQL.Shared
{
    public partial class ModalComponent
    {
        [Parameter]
        public bool ShowModal { get; set; } = false;

        [Parameter]
        public EventCallback<bool> OnResultCallback { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public RenderFragment ItemTemplate { get; set; }

        private void ModalOk()
        {
            OnResultCallback.InvokeAsync(true);
        }
        private void ModalCancel()
        {
            OnResultCallback.InvokeAsync(false);
        }
    }
}
