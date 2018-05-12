// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage;

namespace Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter
{
    /// <summary>Interface for service responsible for getting an Azure Storage account instance</summary>
    public interface ICloudStorageAccountGetter
    {
        /// <summary>Returns the Azure Storage account instance</summary>
        CloudStorageAccount GetAccount();
    }
}
