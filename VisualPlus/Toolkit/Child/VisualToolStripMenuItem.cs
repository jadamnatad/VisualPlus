﻿namespace VisualPlus.Toolkit.Child
{
    #region Namespace

    using System.Drawing;
    using System.Windows.Forms;

    using VisualPlus.Toolkit.Components;

    #endregion

    public sealed class VisualToolStripMenuItem : ToolStripMenuItem
    {
        #region Constructors

        /// <inheritdoc />
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:VisualPlus.Toolkit.Child.VisualToolStripMenuItem" />
        ///     class.
        /// </summary>
        public VisualToolStripMenuItem()
        {
            AutoSize = false;
            Size = new Size(160, 30);
            Font = new Font("Arial", 8.25F);
        }

        #endregion

        #region Overrides

        protected override ToolStripDropDown CreateDefaultDropDown()
        {
            if (DesignMode)
            {
                return base.CreateDefaultDropDown();
            }

            VisualContextMenu defaultDropDown = new VisualContextMenu();
            defaultDropDown.Items.AddRange(base.CreateDefaultDropDown().Items);
            return defaultDropDown;
        }

        #endregion
    }
}