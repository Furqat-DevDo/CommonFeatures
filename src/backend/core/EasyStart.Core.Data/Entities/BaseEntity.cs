// EasyStart - Copyright (C) 2024. GNU GPL v3.0.
// Terms: https://www.gnu.org/licenses/gpl-3.0.html.
// Contact: furqata93@gmail.com.

namespace EasyStart.Core.Data.Entities;

public class BaseEntity <TKey> : IEntity    where TKey : IEquatable<TKey> 
{
    public required TKey Id { get; set; }

    public DateTime CreateDateTime { get; set; }
}