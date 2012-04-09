using System;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Metadata.Edm;
using System.Collections.Generic;

namespace System.Data.Entity.Core
{
    /// <summary>
    /// Interface allowing an IEntityAdapter to analyze state/change tracking information maintained
    /// by a state manager in order to perform updates on a backing store (and push back the results
    /// of those updates).
    /// </summary>
    internal interface IEntityStateManager {
        IEnumerable<IEntityStateEntry> GetEntityStateEntries(EntityState state);
        IEnumerable<IEntityStateEntry> FindRelationshipsByKey(EntityKey key);
        IEntityStateEntry GetEntityStateEntry(EntityKey key);
        bool TryGetEntityStateEntry(EntityKey key, out IEntityStateEntry stateEntry);
        bool TryGetReferenceKey(EntityKey dependentKey, AssociationEndMember principalRole, out EntityKey principalKey);
    }
}