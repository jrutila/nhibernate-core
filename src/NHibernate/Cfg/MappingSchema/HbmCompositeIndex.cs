using System;
using System.Collections.Generic;
using System.Linq;

namespace NHibernate.Cfg.MappingSchema
{
	public partial class HbmCompositeIndex: IComponentMapping
	{
		#region Implementation of IPropertiesContainerMapping

		public IEnumerable<IEntityPropertyMapping> Properties
		{
			get { return Items != null ? Items.Cast<IEntityPropertyMapping>() : new IEntityPropertyMapping[0]; }
		}

		#endregion

		#region Implementation of IComponentMapping

		public string Class
		{
			get { return @class; }
		}

		public HbmParent Parent
		{
			get { return null; }
		}

		public string EmbeddedNode
		{
			get { return null; }
		}

		public string Name
		{
			get { return null; }
		}

		#endregion
	}
}