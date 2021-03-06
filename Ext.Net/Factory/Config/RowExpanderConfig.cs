/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.0.0.beta - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-03-07
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RowExpander
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RowExpander(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RowExpander.Config Conversion to RowExpander
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RowExpander(RowExpander.Config config)
        {
            return new RowExpander(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Plugin.Config 
        { 
			/*  Implicit RowExpander.Config Conversion to RowExpander.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RowExpander.Builder(RowExpander.Config config)
			{
				return new RowExpander.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private XTemplate template = null;

			/// <summary>
			/// The template string to use to display each item in the dropdown list.
			/// </summary>
			public XTemplate Template
			{
				get
				{
					if (this.template == null)
					{
						this.template = new XTemplate();
					}
			
					return this.template;
				}
			}
			        
			private ItemsCollection<AbstractComponent> component = null;

			/// <summary>
			/// 
			/// </summary>
			public ItemsCollection<AbstractComponent> Component
			{
				get
				{
					if (this.component == null)
					{
						this.component = new ItemsCollection<AbstractComponent>();
					}
			
					return this.component;
				}
			}
			
			private bool recreateComponent = false;

			/// <summary>
			/// Recreate component on each row expand
			/// </summary>
			[DefaultValue(false)]
			public virtual bool RecreateComponent 
			{ 
				get
				{
					return this.recreateComponent;
				}
				set
				{
					this.recreateComponent = value;
				}
			}

			private bool swallowBodyEvents = false;

			/// <summary>
			/// Swallow row body's events
			/// </summary>
			[DefaultValue(false)]
			public virtual bool SwallowBodyEvents 
			{ 
				get
				{
					return this.swallowBodyEvents;
				}
				set
				{
					this.swallowBodyEvents = value;
				}
			}

			private bool selectRowOnExpand = false;

			/// <summary>
			/// True to select a row when clicking on the expander icon (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool SelectRowOnExpand 
			{ 
				get
				{
					return this.selectRowOnExpand;
				}
				set
				{
					this.selectRowOnExpand = value;
				}
			}

			private bool expandOnEnter = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ExpandOnEnter 
			{ 
				get
				{
					return this.expandOnEnter;
				}
				set
				{
					this.expandOnEnter = value;
				}
			}

			private bool expandOnDblClick = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ExpandOnDblClick 
			{ 
				get
				{
					return this.expandOnDblClick;
				}
				set
				{
					this.expandOnDblClick = value;
				}
			}

			private bool singleExpand = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool SingleExpand 
			{ 
				get
				{
					return this.singleExpand;
				}
				set
				{
					this.singleExpand = value;
				}
			}
        
			private RowExpanderListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public RowExpanderListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new RowExpanderListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private RowExpanderDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public RowExpanderDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new RowExpanderDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}