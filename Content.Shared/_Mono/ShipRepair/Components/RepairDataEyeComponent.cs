using Robust.Shared.GameStates;

namespace Content.Shared._Mono.ShipRepair.Components;

/// <summary>
/// Added by server to client to tell it that it can now start showing repair ghosts.
/// Needed because without this client will start showing missing entities immediately but that will also show underfloor entities.
/// </summary>
[RegisterComponent, NetworkedComponent]
[AutoGenerateComponentState] // rat-change
public sealed partial class RepairDataEyeComponent : Component
{
    [DataField, AutoNetworkedField] // rat-change
    public int Count = 0;
}
