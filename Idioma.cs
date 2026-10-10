
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EDUSEX
{
    public static class Idioma
    {
        public static string Actual { get; private set; } = "ES";

        public static event Action? IdiomaCambiado;

        private static readonly Dictionary<string, string> Traducciones =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Inicio", "Home" },
            { "Usuarios", "Users" },
            { "Hospitales", "Hospitals" },
            { "Citas", "Appointments" },
            { "Guía educativa", "Educational Guide" },
            { "Guia educativa", "Educational Guide" },
            { "Guardar", "Save" },
            { "Actualizar", "Update" },
            { "Eliminar", "Delete" },
            { "Cancelar", "Cancel" },
            { "Buscar", "Search" },
            { "Nuevo", "New" },
            { "Editar", "Edit" },
            { "Cerrar sesión", "Log out" },
            { "Cerrar Sesión", "Log out" },
            { "Soporte", "Support" },
            { "Aceptar", "Accept" },
            { "Nombre", "First name" },
            { "Apellidos", "Last name" },
            { "Edad", "Age" },
            { "Sexo", "Sex" },
            { "Teléfono", "Phone" },
            { "Telefono", "Phone" },
            { "Correo", "Email" },
            { "Cédula", "ID number" },
            { "Cedula", "ID number" },
            { "Motivo", "Reason" },
            { "Estado", "Status" },
            { "Fecha", "Date" },
            { "Hora", "Time" },
            { "Pendiente", "Pending" },
            { "Confirmada", "Confirmed" },
            { "Confirmado", "Confirmed" },
            { "Masculino", "Male" },
            { "Femenino", "Female" },
            { "Otros", "Other" },
            { "Información", "Information" },
            { "Advertencia", "Warning" },
            { "Error", "Error" },
            { "¿Quieres contactar a Soporte IT?", "Do you want to contact IT Support?" },
            { "Quieres Contactar a Soporte IT ?.", "Do you want to contact IT Support?" },
            { "Seguro que quieres cerrar sesión?", "Are you sure you want to log out?" }
        };

        public static string Traducir(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            foreach (var traduccion in Traducciones)
            {
                if (string.Equals(texto, traduccion.Key,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return Actual == "EN"
                        ? traduccion.Value
                        : traduccion.Key;
                }

                if (string.Equals(texto, traduccion.Value,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return Actual == "EN"
                        ? traduccion.Value
                        : traduccion.Key;
                }
            }

            return texto;
        }

        public static void CambiarIdioma()
        {
            Actual = Actual == "ES" ? "EN" : "ES";
            IdiomaCambiado?.Invoke();
        }

        public static void Aplicar(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                control.Text = Traducir(control.Text);

                if (control is DataGridView tabla)
                {
                    foreach (DataGridViewColumn columna in tabla.Columns)
                    {
                        columna.HeaderText = Traducir(columna.HeaderText);
                    }
                }

                if (control is ComboBox combo)
                {
                    int seleccion = combo.SelectedIndex;

                    for (int i = 0; i < combo.Items.Count; i++)
                    {
                        if (combo.Items[i] is string texto)
                        {
                            combo.Items[i] = Traducir(texto);
                        }
                    }

                    combo.SelectedIndex = seleccion;
                }

                Aplicar(control);
            }
        }
    }
}
