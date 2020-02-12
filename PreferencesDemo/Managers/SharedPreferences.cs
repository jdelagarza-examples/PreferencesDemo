using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace PreferencesDemo
{
    public class SharedPreferences
    {
        public async Task SetSecureAsync(string key, string value)
        {
            await SecureStorage.SetAsync(key, value);
        }

        public Task<string> GetSecureAsync(string key)
        {
            return SecureStorage.GetAsync(key);
        }

        public void Set(string key, string value, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public void Set(string key, double value, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public void Set(string key, int value, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public void Set(string key, bool value, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public void Set(string key, DateTime value, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                Preferences.Set(key, value, sharedName);
            else
                Preferences.Set(key, value);
        }

        public string Get(string key, string defaultValue, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                return Preferences.Get(key, defaultValue, sharedName);
            else
                return Preferences.Get(key, defaultValue);
        }

        public double Get(string key, double defaultValue, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                return Preferences.Get(key, defaultValue, sharedName);
            else
                return Preferences.Get(key, defaultValue);
        }

        public int Get(string key, int defaultValue, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                return Preferences.Get(key, defaultValue, sharedName);
            else
                return Preferences.Get(key, defaultValue);
        }

        public bool Get(string key, bool defaultValue, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                return Preferences.Get(key, defaultValue, sharedName);
            else
                return Preferences.Get(key, defaultValue);
        }

        public DateTime Get(string key, DateTime defaultValue, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                return Preferences.Get(key, defaultValue, sharedName);
            else
                return Preferences.Get(key, defaultValue);
        }

        public void Remove(string key, string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                Preferences.Remove(key, sharedName);
            else
                Preferences.Remove(key);
        }

        public void ClearAllPreferences(string sharedName = null)
        {
            if (!string.IsNullOrEmpty(sharedName) && !string.IsNullOrWhiteSpace(sharedName))
                Preferences.Clear(sharedName);
            else
                Preferences.Clear();
        }

        static SharedPreferences current;
        protected SharedPreferences() { }
        public static SharedPreferences Current
        {
            get
            {
                if (current == null)
                {
                    current = new SharedPreferences();
                }
                return current;
            }
        }
    }
}
