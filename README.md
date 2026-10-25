# FryCircuit

Industrial-grade electronic circuit design, real-time SPICE Modified Nodal Analysis (MNA) simulation, and schematic capture environment for the **FryWorld** ecosystem.

🌐 **Live Web Studio**: [codefrydev.in/FryCircuit](https://codefrydev.in/FryCircuit)

---

## ⚡ Highlights

- **Real-Time SPICE MNA Solver**: Sub-millivolt accuracy nodal matrix solver computing dynamic voltages, branch currents, and non-linear semiconductor responses.
- **21 Engineering Presets**: From 555 timers and op-amps to Josephson Junctions and SQUID magnetometers.
- **Pure C# Particle Simulation**: Live current visualization, animated voltage probes, and oscilloscope telemetry.
- **Universal Runtime**: Native desktop studio, WebAssembly browser edition, and Model Context Protocol (MCP) AI integration.

---

## 🚀 Quick Start

### Build & Run

```bash
# Build the solution
dotnet build FryCircuit.slnx

# Run all 240 tests
dotnet test FryCircuit.slnx

# Launch desktop studio
dotnet run --project Runner/CircuitPlugin.Runner.csproj

# Launch WebAssembly studio locally
dotnet run --project src/FryCircuit.Browser/FryCircuit.Browser.csproj
```

### Publish WebAssembly for GitHub Pages

```bash
dotnet publish src/FryCircuit.Browser/FryCircuit.Browser.csproj -c Release -o release
```

---

## 📜 License

Part of the **FryWorld** ecosystem. MIT License.
