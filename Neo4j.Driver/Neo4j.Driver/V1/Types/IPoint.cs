﻿// Copyright (c) 2002-2018 "Neo Technology,"
// Network Engine for Objects in Lund AB [http://neotechnology.com]
// 
// This file is part of Neo4j.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// ReSharper disable once CheckNamespace

using System;

namespace Neo4j.Driver.V1
{
    /**
     * Represents a single three-dimensional point in a particular coordinate reference system.
     */
    public interface IPoint : IValue
    {
        /**
         * The coordinate reference system identifier
         */
        int SrId { get; }

        /**
         * X coordinate of the point
         */
        double X { get; }

        /**
         * Y coordinate of the point
         */
        double Y { get; }

        /**
         * Z coordinate of the point
         */
        double Z { get; }
    }
}