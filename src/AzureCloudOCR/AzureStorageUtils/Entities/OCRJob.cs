﻿// Copyright (c) Yuriy Guts, 2013
// 
// Licensed under the Apache License, version 2.0 (the "License").
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at:
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace AzureStorageUtils.Entities
{
    public class OCRJob : TableEntity
    {
        public Guid ID { get; set; }

        public string EmailAddress { get; set; }

        public string OriginalFileName { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsCompleted { get; set; }

        public string ErrorMessage { get; set; }
    }
}