using System;
using System.Collections.Generic;
using System.Text;
// NEW 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MarsEncrypter
{
    public class DataGridViewProgressColumn : DataGridViewImageColumn
    {
        public DataGridViewProgressColumn()
        {
            CellTemplate = new DataGridViewProgressCell();
        }
    }

    public class DataGridViewProgressCell : DataGridViewImageCell
    {
        static Image proEmptyImage;
        static DataGridViewProgressCell()
        {
            // The custom cell must be consistent with a DataGridViewImageCell
            proEmptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        
        public DataGridViewProgressCell()
        {
            ValueType = typeof(int);
        }
        
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            // This method is required to make the ProgressCell consistent with the default ImageCell. 
            return proEmptyImage;
        }

        protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            int liProgressPercentage;

            if (value == null)
            {
                liProgressPercentage = 0;
            }
            else
            {
                liProgressPercentage = (int)value;
            }

            float lfPercentage = ((float) liProgressPercentage / 100.0f);
            Brush loForeColorBrush = new SolidBrush(cellStyle.ForeColor);
            // Draws the grid for the cell
            base.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));
            if (lfPercentage > 0.0)
            {
                // Draw the progress bar
                g.FillRectangle(new SolidBrush(Color.FromArgb(163, 189, 242)), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((lfPercentage * cellBounds.Width - 4)), cellBounds.Height - 4);
                // Draw a string showing the percentage value
                g.DrawString(liProgressPercentage.ToString() + "%", cellStyle.Font, loForeColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
            }
            else
            {
                if (this.DataGridView.CurrentRow == null)
                {
                    // Draw a string showing the percentage value
                    g.DrawString(liProgressPercentage.ToString() + "%", cellStyle.Font, loForeColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                }
                else
                {
                    if (this.DataGridView.CurrentRow.Index == rowIndex)
                    {
                        // Draw a string showing the percentage value using the selection fore color
                        g.DrawString(liProgressPercentage.ToString() + "%", cellStyle.Font, new SolidBrush(cellStyle.SelectionForeColor), cellBounds.X + 6, cellBounds.Y + 2);
                    }
                    else
                    {
                        // Draw a string showing the percentage value
                        g.DrawString(liProgressPercentage.ToString() + "%", cellStyle.Font, loForeColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                    }
                }
            }
        }
    }
}
