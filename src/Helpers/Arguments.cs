using System.Reflection;
using LibCamera.Settings.Records;

namespace LibCamera.Helpers
{
    public abstract class Arguments
    {
        public override string ToString()
        {
            string args = "";

            foreach (PropertyInfo property in GetType().GetProperties())
            {
                ArgumentAttribute? argument = property.GetCustomAttribute<ArgumentAttribute>();

                if (argument is null) continue;

                var value = property.GetValue(this);

                if (value is null) continue;

                if (value is bool a && !a) continue;

                if (value is bool b && b)
                {
                    args += $" {argument.Argument}";
                    continue;
                }

                if (value is uint c)
                {
                    args += $" {argument.Argument} {c}";
                    continue;
                }

                if (value is decimal d)
                {
                    args += $" {argument.Argument} {d}";
                    continue;
                }

                if (value is string e)
                {
                    args += $" {argument.Argument} {e}";
                    continue;
                }

                if (value is Crop f)
                {
                    args += $" {argument.Argument} {f}";
                    continue;
                }

                if (value is WhiteBalanceGains g)
                {
                    args += $" {argument.Argument} {g}";
                    continue;
                }

                if (value is Enumeration<uint> h)
                {
                    args += $" {argument.Argument} {h}";
                    continue;
                }

                if (value is Enumeration<string> i)
                {
                    args += $" {argument.Argument} {i}";
                    continue;
                }
            }

            return args;
        }
    }
}