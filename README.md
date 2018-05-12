# Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-account-interfaces-cl.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-account-interfaces-cl)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter)

## Description

Interface for service responsible for getting an Azure Storage account instance

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Azure.Storage.Metapackage](https://github.com/CDorst/Azure.Storage.Metapackage) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-metapackage.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-metapackage) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Metapackage.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Metapackage)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[Cloud.Azure.Storage.Services.Account.Getter](https://github.com/CDorst/Cloud.Azure.Storage.Services.Account.Getter) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-account-getter.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-account-getter) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Account.Getter.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Getter)
[Cloud.Azure.Storage.Services.Blobs.BlobClientGetter](https://github.com/CDorst/Cloud.Azure.Storage.Services.Blobs.BlobClientGetter) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-blobclientgette.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-blobclientgette) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobClientGetter.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobClientGetter)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter)

## Version

1.0.0

## Metaproject

Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

