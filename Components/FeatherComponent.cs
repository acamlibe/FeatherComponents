using Microsoft.AspNetCore.Components;

namespace FC.Components;

public class FeatherComponent : ComponentBase
{
    [Parameter]
    public bool AutoRender { get; set; }
    
    private bool _shouldRender;

    protected override bool ShouldRender() => AutoRender || _shouldRender;
    protected override void OnAfterRender(bool firstRender) => _shouldRender = false;

    public void Render()
    {
        _shouldRender = true;
        StateHasChanged();
    }
}