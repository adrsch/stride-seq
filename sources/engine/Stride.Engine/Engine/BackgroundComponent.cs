// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System.ComponentModel;

using Stride.Core;
using Stride.Core.Annotations;
using Stride.Engine.Design;
using Stride.Engine.Processors;
using Stride.Graphics;
using Stride.Rendering;
using Stride.Rendering.Background;

namespace Stride.Engine
{
    /// <summary>
    /// Add a background to an <see cref="Entity"/>.
    /// </summary>
    [DataContract("BackgroundComponent")]
    [Display("Background", Expand = ExpandRule.Once)]
    [DefaultEntityComponentRenderer(typeof(BackgroundRenderProcessor))]
    [ComponentOrder(9600)]
    public sealed class BackgroundComponent : ActivableEntityComponent
    {
        /// <summary>
        /// Create an empty Background component.
        /// </summary>
        public BackgroundComponent()
        {
            Intensity = 1f;
        }

        /// <summary>
        /// Gets or sets the texture to use as background
        /// </summary>
        /// <userdoc>The reference to the texture to use as background</userdoc>
        [DataMember(10)]
        [Display("Texture")]
        public Texture Texture { get; set; }

        [DataMember(11)]
        public Texture TextureB;
        [DataMember(12)]
        public float Mix;

        /// <summary>
        /// Gets or sets the intensity.
        /// </summary>
        /// <value>The intensity.</value>
        /// <userdoc>The intensity of the background color</userdoc>
        [DataMember(20)]
        [DefaultValue(1.0f)]
        [DataMemberRange(0.0, 100.0, 0.01f, 1.0f, 2)]
        public float Intensity { get; set; }

        /// <summary>
        /// The render group for this component.
        /// </summary>
        [DataMember(30)]
        [Display("Render group")]
        [DefaultValue(RenderGroup.Group0)]
        public RenderGroup RenderGroup { get; set; }

        /// <summary>
        /// Indicate if the background should behave like a 2D image.
        /// </summary>
        /// <userdoc>Use the texture as a static 2D background (useful for 2D applications)</userdoc>
        [DataMember(40)]
        [Display("2D background")]
        [DefaultValue(false)]
        public bool Is2D { get; set; } = false;
    }
}
