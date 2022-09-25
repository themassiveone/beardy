## Status: Partially abandoned & unfinshed

This Repository is **partially abandoned**, because of multiple Reasons:

- The cli framework idea attempt has been replaced with using https://github.com/Cysharp/ConsoleAppFramework instead
- Statically defined templates are not flexible enough.
- The idea of generating project stubs has been replaced with generating entire projects with
  https://github.com/MassiveCreationLab/layer8
- Code quality & usage amount of business standards was insufficient
- Inflexibility: Beardy only makes sense using a locally(same network) hosted api, that generates project files and saves them to a client accessible nfs/smb share.

This repository might be resurrected as soon as MetaCode/Layer8(https://github.com/MassiveCreationLab/layer8) is ready for modular Logic components.

To preserve **privacy**, configuration files and the previous git history have been stripped from this repo.

# Beardy

**Beardy** is an attempt at creating an easy way to generate projects stubs of many different types spanning over different kinds of frameworks, languages and architectures.

## Beardy CLI

**Beardy CLI** makes use of the custom cli framework to communicate with Beardy API. This is supposed to be a "dev-friendly" way to incoporate the system into already established workflows.

## Beardy API

**Beardy API** provides a way to centrally store project metadata. Many cli clients can connect to this restfull API. Implementing a UI may be an improvement to usability ot the system. Code generation is also computed here.

## Custom CLI Framework

This nameless cli framework is supposed to ease the creation of dotnet based cli projects.

## Name

Beardy as a repo name has been invented, by fetching one more word out of the context of following framework names:

- https://github.com/StubbleOrg/Stubble
- https://mustache.github.io/
