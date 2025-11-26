# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a Unity 6000.2.10f1 project named "Project_E" configured for study and learning purposes. The project uses Universal Render Pipeline (URP) and includes basic Unity packages for general game development.

## Unity Project Structure

- **Assets/Scenes/**: Contains the main scene files
  - `Study_01.unity` - Primary scene for development
  - `Study.cs` - Main script for study/learning purposes
- **Assets/TutorialInfo/**: Unity tutorial documentation system
- **ProjectSettings/**: Unity project configuration files
- **Packages/manifest.json**: Defines Unity package dependencies

## Key Unity Packages

- Universal Render Pipeline (URP) 17.2.0
- Input System 1.14.2
- Visual Scripting 1.9.8
- Test Framework 1.6.0
- AI Navigation 2.0.9

## Development Commands

Since this is a Unity project, development is primarily done through the Unity Editor. However, when working with C# scripts:

- Unity will automatically compile scripts when changed
- Use Unity Editor's Console window to view compilation errors
- Test through Play Mode in Unity Editor
- Build through Unity Editor: File > Build Settings

## Code Conventions

- Follow Unity C# naming conventions (PascalCase for public members, camelCase for private)
- Place MonoBehaviour scripts in appropriate folder structure under Assets/
- Use Unity's component-based architecture patterns
- Prefer Unity's built-in systems (Transform, Rigidbody, etc.) over custom implementations

## File Organization

- C# scripts should be organized logically within the Assets/ folder
- Scene files (.unity) belong in Assets/Scenes/
- Maintain .meta files alongside all assets for Unity's asset tracking
- Keep project-level settings in ProjectSettings/ (managed by Unity)

## Important Notes

- This appears to be a study/learning project based on naming conventions
- The project uses URP, so rendering features should be URP-compatible
- Input System package is included, so prefer new Input System over legacy input
- Visual Scripting is available for node-based programming alongside traditional C# scripts