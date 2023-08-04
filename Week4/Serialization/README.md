# Serialization and Assemblies

**Serialziation** is a conversion of C# objects to data interchange formats. Namely `JSON`, binary or `XML` in order to separate dynamic and large default objects from the main program.

## Types of Serialization

1. Binary serialization => for less extensibility in read-only variables
2. XML => when extensibility is mandatory, and the data size is arguably small
3. JSON => when extensibility is mandatory, and the data size is larger and might be cumbersome to read.