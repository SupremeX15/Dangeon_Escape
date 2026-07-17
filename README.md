# Dungeon Escape

A dungeon escape game developed with **Unreal Engine 5.6**, featuring dynamic AI-driven gameplay, engaging UI systems, and state-based behavior trees.

## Project Overview

**Dungeon Escape** is an action-adventure game project built in Unreal Engine 5.6. The game emphasizes intelligent enemy AI, interactive level design, and immersive player experiences through advanced game mechanics and visual systems.

## Technology Stack

- **Engine:** Unreal Engine 5.6
- **Primary Language:** C++ (98.1%)
- **Secondary Languages:** C# (1.7%), C (0.2%)
- **Key Frameworks:**
  - AIModule (Enemy AI and behavior systems)
  - StateTree (Behavior tree-based AI logic)
  - GameplayStateTree (Gameplay state management)
  - UMG (User interface and HUD systems)
  - Modeling Tools (Level design and prototyping)

## Project Structure

```
Dangeon_Escape/
├── Source/
│   ├── Dangeon_Escape/           # Game module source code
│   ├── Dangeon_Escape.Target.cs   # Game target configuration
│   └── Dangeon_EscapeEditor.Target.cs  # Editor target configuration
├── Content/                       # Game assets, levels, and blueprints
├── Config/                        # Project configuration files
└── Dangeon_Escape.uproject       # Unreal Engine project file
```

## Getting Started

### Prerequisites

- **Unreal Engine 5.6** or later
- **Visual Studio 2022** (recommended) or compatible C++ IDE
- **Windows 10/11** or **Mac** (Intel/Apple Silicon)
- Minimum 8 GB RAM, 50 GB free disk space

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/SupremeX15/Dangeon_Escape.git
   cd Dangeon_Escape
   ```

2. **Generate Visual Studio project files:**
   - Right-click `Dangeon_Escape.uproject` → **Generate Visual Studio project files**

3. **Open the project:**
   - Double-click `Dangeon_Escape.uproject` to open in Unreal Engine
   - Accept any prompts to rebuild the project

4. **Compile the project:**
   - In Unreal Editor: **Tools** → **Compile**
   - Or use Visual Studio to compile the C++ modules

## Features

### Core Gameplay

- **Intelligent AI System** - Utilizing Unreal's AIModule and StateTree for responsive enemy behavior
- **Dynamic Level Design** - Interactive environments with state-based mechanics
- **Advanced UI** - Comprehensive user interface built with UMG
- **Immersive Escape Mechanics** - Puzzle-solving and survival elements

### Technical Highlights

- Modular C++ architecture for maintainability and scalability
- State tree-based AI behavior for flexible enemy logic
- Blueprint integration for rapid iteration and level design
- Optimized asset streaming and memory management

## Development

### Building the Project

**From Unreal Editor:**
- Select your target platform (Windows, Mac, etc.)
- Click **Platforms** → **Package Project** → Select destination

**From Command Line:**
```bash
Engine/Build/BatchFiles/RunUAT.bat BuildCookRun -project="Dangeon_Escape.uproject" \
  -platform=Win64 -cook -stage -package -archive -archivedirectory="Build"
```

### Code Style and Conventions

- Follows **Unreal Engine Coding Standards**
- C++ modules use clear naming conventions (e.g., `FCharacterController`, `AEnemyAI`)
- Blueprint classes are documented and organized in the Content browser

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes with descriptive messages
4. Push to the branch and submit a Pull Request

Please ensure your code follows Unreal Engine standards and is thoroughly tested before submitting.

## Performance Optimization

- **Asset Management:** Optimize textures, meshes, and skeletal animations
- **AI Systems:** Use LOD (Level of Detail) for distant AI agents
- **Rendering:** Leverage Nanite for high-poly static meshes
- **Memory:** Profile with Unreal Insights to identify bottlenecks

## Troubleshooting

### Project Won't Open
- Delete `Binaries`, `Intermediate`, and `Saved` folders
- Regenerate Visual Studio project files
- Clean rebuild the project

### Compilation Errors
- Ensure Unreal Engine 5.6 is properly installed
- Check that Visual Studio is set as the default IDE
- Clear intermediate build files and recompile

## License

This project is provided as-is for educational and development purposes. Please refer to any included LICENSE file for specific terms.

## Contact & Support

For questions, issues, or discussions:
- **GitHub Issues:** [Report a bug or suggest a feature](https://github.com/SupremeX15/Dangeon_Escape/issues)
- **GitHub Discussions:** [General questions and discussions](https://github.com/SupremeX15/Dangeon_Escape/discussions)

## Additional Resources

- [Unreal Engine Documentation](https://docs.unrealengine.com/)
- [Unreal Engine AI Framework](https://docs.unrealengine.com/5.6/en-US/unreal-engine-ai-framework/)
- [StateTree Plugin Documentation](https://docs.unrealengine.com/5.6/en-US/statetree-plugin/)

---

**Developed with** ❤️ **using Unreal Engine 5.6**
