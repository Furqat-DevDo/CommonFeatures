// Easy Start
// Copyright (C) 2024
// 
// This file is licensed under the GNU General Public License v3.0.
// Redistribution, modification, or use of this file is allowed according to the terms of the License.
// Full license details: https://www.gnu.org/licenses/gpl-3.0.html.
// 
// This project is open source but may transition to a paid license in the future.
// Please refer to furqata93@gmail.com for updated licensing information.

namespace EasyStart.Core.Data.Entities;

public class BaseEntity <TKey> : IEntity    where TKey : IEquatable<TKey> 
{
    public required TKey Id { get; set; }

    public DateTime CreateDateTime { get; set; }
}