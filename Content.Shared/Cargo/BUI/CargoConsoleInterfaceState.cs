using Content.Shared.Cargo.Prototypes;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Content.Shared.CrewManifest;

namespace Content.Shared.Cargo.BUI;

[NetSerializable, Serializable]
public sealed class CargoConsoleInterfaceState : BoundUserInterfaceState
{
    public string Name;
    public int Count;
    public int Capacity;
    public NetEntity Station;
    public List<CargoOrderData> Orders;
    public CrewManifestEntries? CrewManifest;  // Harmony change -- crewManifest added for cargo orders QoL (Crew list)

    public List<ProtoId<CargoProductPrototype>> Products;
    public CargoConsoleInterfaceState(string name, int count, int capacity, NetEntity station, List<CargoOrderData> orders, CrewManifestEntries? crewManifest, List<ProtoId<CargoProductPrototype>> products)
    {
        Name = name;
        Count = count;
        Capacity = capacity;
        Station = station;
        Orders = orders;
        CrewManifest = crewManifest;
        Products = products;
    }
}
