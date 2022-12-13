﻿// <copyright file="TestEmailGroup.cs" company="WavePoint Co. Ltd.">
// Licensed under the MIT license. See LICENSE file in the samples root for full license information.
// </copyright>

using System;
using Nest;
using OnlineSales.DTOs;

namespace OnlineSales.Tests.TestEntities;

public class TestEmailGroup : EmailGroupCreateDto
{
    public TestEmailGroup()
    {
        Name = "TestEmailGroup";
    }
}