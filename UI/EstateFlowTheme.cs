using System.Drawing;
using System.Windows.Forms;

namespace EstateFlow;

public enum EstateFlowButtonStyle
{
    Primary,
    Success,
    Warning,
    Danger,
    Info,
    Neutral,
    Dark
}

public static class EstateFlowTheme
{
    public static readonly Color AppBackground = Color.FromArgb(245, 247, 251);
    public static readonly Color CardBackground = Color.White;
    public static readonly Color TextDark = Color.FromArgb(30, 41, 59);
    public static readonly Color TextMuted = Color.FromArgb(100, 116, 139);
    public static readonly Color BorderColor = Color.FromArgb(226, 232, 240);
    public static readonly Color Primary = Color.FromArgb(37, 99, 235);
    public static readonly Color Success = Color.FromArgb(22, 163, 74);
    public static readonly Color Warning = Color.FromArgb(245, 158, 11);
    public static readonly Color Danger = Color.FromArgb(220, 38, 38);
    public static readonly Color Info = Color.FromArgb(14, 165, 233);
    public static readonly Color Neutral = Color.FromArgb(71, 85, 105);
    public static readonly Color Dark = Color.FromArgb(15, 23, 42);

    public static void ApplyForm(Form form)
    {
        form.BackColor = AppBackground;
        form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
    }

    public static void ApplyTitle(Label label)
    {
        label.ForeColor = TextDark;
        label.Font = new Font("Segoe UI Semibold", label.Font.Size, FontStyle.Bold);
    }

    public static void ApplyLabel(Label label)
    {
        label.ForeColor = TextMuted;
        label.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
    }

    public static void ApplyInput(Control control)
    {
        control.BackColor = CardBackground;
        control.ForeColor = TextDark;
        control.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
    }

    public static void ApplyButton(Button button, EstateFlowButtonStyle style)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Cursor = Cursors.Hand;
        button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        button.ForeColor = Color.White;
        button.BackColor = GetButtonColor(style);
        button.UseVisualStyleBackColor = false;
    }

    public static void ApplyCard(Label label, Color accentColor)
    {
        label.BackColor = CardBackground;
        label.ForeColor = accentColor;
        label.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        label.BorderStyle = BorderStyle.FixedSingle;
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.Padding = new Padding(8);
    }

    public static void ApplyGrid(DataGridView grid)
    {
        grid.BackgroundColor = CardBackground;
        grid.BorderStyle = BorderStyle.None;
        grid.GridColor = BorderColor;
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersDefaultCellStyle.BackColor = Dark;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Dark;
        grid.DefaultCellStyle.BackColor = CardBackground;
        grid.DefaultCellStyle.ForeColor = TextDark;
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
        grid.DefaultCellStyle.SelectionForeColor = TextDark;
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        grid.RowHeadersVisible = false;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToResizeRows = false;
        grid.RowTemplate.Height = 32;
        grid.ColumnHeadersHeight = 38;
    }

    private static Color GetButtonColor(EstateFlowButtonStyle style)
    {
        return style switch
        {
            EstateFlowButtonStyle.Success => Success,
            EstateFlowButtonStyle.Warning => Warning,
            EstateFlowButtonStyle.Danger => Danger,
            EstateFlowButtonStyle.Info => Info,
            EstateFlowButtonStyle.Neutral => Neutral,
            EstateFlowButtonStyle.Dark => Dark,
            _ => Primary
        };
    }
}
