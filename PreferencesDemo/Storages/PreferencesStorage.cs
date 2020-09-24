using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace PreferencesDemo.Storages
{
    public static class PreferencesStorage
    {
        public static async Task SetSecureAsync(string key, string value)
        {
            try
            {
                await SecureStorage.SetAsync(key, value);
            }
            catch (Exception)
            {
            }
        }

        public static async Task<string> GetSecureAsync(string key)
        {
            var value = "";
            try
            {
                value = await SecureStorage.GetAsync(key).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }
            return value;
        }

        public static void Set(string key, string value, string sharedName = null)
        {
            if (IsValidSharedName(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public static void Set(string key, double value, string sharedName = null)
        {
            if (IsValidSharedName(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public static void Set(string key, int value, string sharedName = null)
        {
            if (IsValidSharedName(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public static void Set(string key, bool value, string sharedName = null)
        {
            if (IsValidSharedName(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public static void Set(string key, DateTime value, string sharedName = null)
        {
            if (IsValidSharedName(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public static string Get(string key, string defaultValue, string sharedName = null)
        {
            var value = default(string);
            if (IsValidSharedName(sharedName))
                value = Preferences.Get(key, defaultValue, sharedName);
            else
                value = Preferences.Get(key, value);
            return value;
        }

        public static double Get(string key, double defaultValue, string sharedName = null)
        {
            var value = default(double);
            if (IsValidSharedName(sharedName))
                value = Preferences.Get(key, defaultValue, sharedName);
            else
                value = Preferences.Get(key, value);
            return value;
        }

        public static int Get(string key, int defaultValue, string sharedName = null)
        {
            var value = default(int);
            if (IsValidSharedName(sharedName))
                value = Preferences.Get(key, defaultValue, sharedName);
            else
                value = Preferences.Get(key, value);
            return value;
        }

        public static bool Get(string key, bool defaultValue, string sharedName = null)
        {
            var value = default(bool);
            if (IsValidSharedName(sharedName))
                value = Preferences.Get(key, defaultValue, sharedName);
            else
                value = Preferences.Get(key, value);
            return value;
        }

        public static DateTime Get(string key, DateTime defaultValue, string sharedName = null)
        {
            var value = default(DateTime);
            if (IsValidSharedName(sharedName))
                value = Preferences.Get(key, defaultValue, sharedName);
            else
                value = Preferences.Get(key, value);
            return value;
        }

        public static void Remove(string key, string sharedName = null)
        {
            if (IsValidSharedName(sharedName))
                Preferences.Remove(key, sharedName);
            else
                Preferences.Remove(key);
        }

        public static void ClearAllPreferences(string sharedName = null)
        {
            if (IsValidSharedName(sharedName))
                Preferences.Clear(sharedName);
            else
                Preferences.Clear();
        }

        static bool IsValidSharedName(string sharedName)
        {
            return !string.IsNullOrEmpty(sharedName) &&
                !string.IsNullOrWhiteSpace(sharedName);
        }
    }
}