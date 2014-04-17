OpenCL
======

An open source OpenCL wrapper written in C#. Usable with all .NET versions since 2.0.

OpenCL.Build
======

OpenCL command line compiler. Selects a default device and compiles a given source file.

Usage:
OpenCL.Build file.cl [OpenCL Compiler Commandline]

Everything after the filename is passed directly to the OpenCL clBuildProgram function.