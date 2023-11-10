//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;
//using Newtonsoft.Json.Linq;
//using System.Collections;
//using System.ComponentModel;
//using System.Reflection;
//using System.Text;

//namespace Hongyu.framework.Common.Json
//{
//    public static class JsonHelp
//    {
//        /// <summary>
//        /// Json字符串转换为实体集合
//        /// </summary>
//        /// <typeparam name="T">实体类</typeparam>
//        /// <param name="json">Json字符串</param>
//        /// <returns>实体集合</returns>
//        public static T ConvertJsonToEntity<T>(string json) where T : class
//        {
//            return JsonConvert.DeserializeObject<T>(json);
//        }

//        /// <summary>
//        /// Json字符串转换为实体集合
//        /// </summary>
//        /// <typeparam name="T">实体类</typeparam>
//        /// <param name="json">Json字符串</param>
//        /// <returns>added对应新增实体集合；deleted对应删除实体集合；modified对应更新实体集合</returns>
//        public static Dictionary<string, IEnumerable<T>> ConvertJsonToEntities<T>(string json) where T : new()
//        {
//            Dictionary<string, IEnumerable<T>> _return = new Dictionary<string, IEnumerable<T>>();
//            IList<T> added = new List<T>();
//            IList<T> deleted = new List<T>();
//            IList<T> modified = new List<T>();
//            ArrayList _c = MiniUIJson.Decode(json) as ArrayList;
//            foreach (Hashtable row in _c)
//            {
//                T t = new T();
//                PropertyInfo[] p = typeof(T).GetProperties();
//                foreach (var item in p)
//                {
//                    string _temp = (row[item.Name] ?? string.Empty).ToString();
//                    if (item.PropertyType.ToString().Contains(@"System.Int32"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        item.SetValue(t, Convert.ToInt32(_temp));
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"System.Int16"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        item.SetValue(t, Convert.ToInt16(_temp));
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"System.Byte[]"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        item.SetValue(t, Encoding.Default.GetBytes(_temp));
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"System.Byte"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        item.SetValue(t, Convert.ToByte(_temp));
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"System.Decimal"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        if (_temp == "null") continue;
//                        item.SetValue(t, Convert.ToDecimal(_temp));
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"System.DateTime"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        item.SetValue(t, Convert.ToDateTime(_temp));
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"System.Boolean"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        item.SetValue(t, Convert.ToBoolean(_temp));
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"System.Double"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        item.SetValue(t, Convert.ToDouble(_temp));
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"CPPEI.Model"))
//                    {
//                        continue;
//                    }
//                    else if (item.PropertyType.ToString().Contains(@"System.Guid"))
//                    {
//                        if (_temp == string.Empty) continue;
//                        item.SetValue(t, Guid.Parse(_temp));
//                    }
//                    else
//                    {
//                        item.SetValue(t, Convert.ChangeType(row[item.Name], item.PropertyType));
//                    }
//                }
//                String state = (row["_state"] ?? string.Empty).ToString();
//                switch (state.ToLower())
//                {
//                    case "added":
//                        added.Add(t);
//                        break;
//                    case "removed":
//                        deleted.Add(t);
//                        break;
//                    case "deleted":
//                        deleted.Add(t);
//                        break;
//                    case "":
//                    case "modified":
//                        modified.Add(t);
//                        break;
//                    default:
//                        break;
//                }
//            }
//            _return.Add("added", added);
//            _return.Add("deleted", deleted);
//            _return.Add("modified", modified);
//            return _return;
//        }

//        /// <summary>
//        /// Json字符串转换为实体集合
//        /// </summary>
//        /// <typeparam name="T">实体类</typeparam>
//        /// <param name="_json">Json字符串</param>
//        /// <returns>added对应新增实体集合；deleted对应删除实体集合；modified对应更新实体集合</returns>
//        public static Dictionary<string, IEnumerable<T>> JsonToEntities<T>(string _json) where T : new()
//        {
//            if (string.IsNullOrWhiteSpace(_json))
//                return null;
//            Dictionary<string, IEnumerable<T>> _list = new Dictionary<string, IEnumerable<T>>();
//            IList<T> added = new List<T>();
//            IList<T> deleted = new List<T>();
//            IList<T> modified = new List<T>();
//            object _r = JsonConvert.DeserializeObject(_json);
//            if (_r is IEnumerable<JToken>)
//            {
//                foreach (IEnumerable<KeyValuePair<string, JToken>> _i in _r as IEnumerable<JToken>)
//                {
//                    Hashtable ht = new Hashtable();
//                    foreach (KeyValuePair<string, JToken> _k in _i)
//                    {
//                        #region 循环属性
//                        if (typeof(JValue) == _k.Value.GetType())
//                        {
//                            object _m = (_k.Value as JValue).Value;
//                            if (_m != null)
//                            {
//                                //判断是否符合2010-09-02T10:00:00的格式
//                                string s = _m.ToString();
//                                if (s.Length == 19 && s[10] == 'T' && s[4] == '-' && s[13] == ':')
//                                {
//                                    ht[_k.Key] = Convert.ToDateTime(s);
//                                }
//                                else
//                                {
//                                    ht[_k.Key] = s;
//                                }
//                            }
//                        }
//                        #endregion
//                    }
//                    T t = new T();
//                    foreach (var item in typeof(T).GetProperties())
//                    {
//                        if (!item.GetGetMethod().IsVirtual && ht[item.Name] != null)
//                        {
//                            if (ht[item.Name].ToString() == string.Empty && item.PropertyType.Name != @"String")
//                            {
//                                string[] _ijk = { "Int32", "Int16", "Byte", "Decimal", "Double", "Single" };
//                                if (_ijk.Contains(item.PropertyType.Name) || _ijk.Contains(item.PropertyType.GenericTypeArguments[0].Name))
//                                {
//                                    ht[item.Name] = 0;
//                                }
//                            }
//                            item.SetValue(t, ChangeType(ht[item.Name], item.PropertyType));
//                        }
//                    }
//                    switch ((ht["_state"] ?? string.Empty).ToString())
//                    {
//                        case "added":
//                            added.Add(t);
//                            break;
//                        case "removed":
//                        case "deleted":
//                            deleted.Add(t);
//                            break;
//                        case "":
//                        case "modified":
//                            modified.Add(t);
//                            break;
//                        default:
//                            break;
//                    }
//                }
//            }
//            _list.Add("added", added);
//            _list.Add("deleted", deleted);
//            _list.Add("modified", modified);
//            return _list;
//        }

//        /// <summary>
//        /// 输入JSON,返回HASH集合
//        /// </summary>
//        /// <param name="_json">json字符串</param>
//        /// <returns>参数集合</returns>
//        public static IEnumerable<Hashtable> JsonToIEnumerable(string _json)
//        {
//            if (string.IsNullOrWhiteSpace(_json))
//                return null;
//            IList<Hashtable> _list = new List<Hashtable>();
//            object _r = JsonConvert.DeserializeObject(_json);
//            if (_r is IEnumerable<JToken>)
//            {
//                foreach (IEnumerable<KeyValuePair<string, JToken>> _i in _r as IEnumerable<JToken>)
//                {
//                    Hashtable ht = new Hashtable();
//                    foreach (KeyValuePair<string, JToken> _k in _i)
//                    {
//                        #region 循环属性
//                        if (typeof(JValue) == _k.Value.GetType())
//                        {
//                            object _m = (_k.Value as JValue).Value;
//                            if (_m != null)
//                            {
//                                //判断是否符合2010-09-02T10:00:00的格式
//                                string s = _m.ToString();
//                                if (s.Length == 19 && s[10] == 'T' && s[4] == '-' && s[13] == ':')
//                                {
//                                    ht[_k.Key] = Convert.ToDateTime(s);
//                                }
//                                else
//                                {
//                                    ht[_k.Key] = s;
//                                }
//                            }
//                        }
//                        #endregion
//                    }
//                    _list.Add(ht);
//                }
//            }
//            return _list;
//        }

//        /// <summary>
//        /// 输入JSON,返回字典
//        /// </summary>
//        /// <param name="_json">json字符串</param>
//        /// <returns>参数集合</returns>
//        public static Dictionary<string, string> JsonToDictionary(string _json)
//        {
//            if (string.IsNullOrWhiteSpace(_json))
//                return null;
//            Dictionary<string, string> _list = new Dictionary<string, string>();
//            object _r = JsonConvert.DeserializeObject(_json);
//            if (_r is IEnumerable<JToken>)
//            {
//                foreach (IEnumerable<KeyValuePair<string, JToken>> _i in _r as IEnumerable<JToken>)
//                {
//                    foreach (KeyValuePair<string, JToken> _k in _i)
//                    {
//                        #region 循环属性
//                        if (typeof(JValue) == _k.Value.GetType())
//                        {
//                            object _m = (_k.Value as JValue).Value;
//                            if (_m != null)
//                            {
//                                //判断是否符合2010-09-02T10:00:00的格式
//                                string s = _m.ToString();
//                                if (s.Length == 19 && s[10] == 'T' && s[4] == '-' && s[13] == ':')
//                                {
//                                    _list.Add(_k.Key, Convert.ToDateTime(s).ToString());
//                                }
//                                else
//                                {
//                                    _list.Add(_k.Key, _k.Value.ToString());
//                                }
//                            }
//                        }
//                        #endregion
//                    }
//                }
//            }
//            return _list;
//        }

//        /// <summary>
//        /// 输入JSON,返回字典
//        /// </summary>
//        /// <param name="_json">json字符串</param>
//        /// <returns>参数集合</returns>
//        public static IEnumerable<KeyValuePair<string, string>> JsonToIEDictionary(string _json)
//        {
//            if (string.IsNullOrWhiteSpace(_json))
//                return null;
//            IList<KeyValuePair<string, string>> _list = new List<KeyValuePair<string, string>>();
//            object _r = JsonConvert.DeserializeObject(_json);
//            if (_r is IEnumerable<JToken>)
//            {
//                foreach (IEnumerable<KeyValuePair<string, JToken>> _i in _r as IEnumerable<JToken>)
//                {
//                    foreach (KeyValuePair<string, JToken> _k in _i)
//                    {
//                        #region 循环属性
//                        if (typeof(JValue) == _k.Value.GetType())
//                        {
//                            object _m = (_k.Value as JValue).Value;
//                            if (_m != null)
//                            {
//                                //判断是否符合2010-09-02T10:00:00的格式
//                                string s = _m.ToString();
//                                if (s.Length == 19 && s[10] == 'T' && s[4] == '-' && s[13] == ':')
//                                {
//                                    _list.Add(new KeyValuePair<string, string>(_k.Key, Convert.ToDateTime(s).ToString()));
//                                }
//                                else
//                                {
//                                    _list.Add(new KeyValuePair<string, string>(_k.Key, _k.Value.ToString()));
//                                }
//                            }
//                        }
//                        #endregion
//                    }
//                }
//            }
//            return _list;
//        }

//        /// <summary>
//        /// 实体对象转换为字符串
//        /// </summary>
//        /// <param name="o">实体对象</param>
//        /// <returns>字符串</returns>
//        public static string EntitiesToString(object o)
//        {
//            if (o == null || o.ToString() == "null") return null;

//            if (o != null && (o.GetType() == typeof(String) || o.GetType() == typeof(string)))
//            {
//                return o.ToString();
//            }
//            IsoDateTimeConverter dt = new IsoDateTimeConverter();
//            dt.DateTimeFormat = @"yyyy'-'MM'-'dd'T'HH':'mm':'ss";
//            return JsonConvert.SerializeObject(o, dt);
//        }

//        /// <summary>
//        /// 类型转换
//        /// </summary>
//        /// <param name="value">数据</param>
//        /// <param name="targetType">类型</param>
//        /// <returns>数据类型</returns>
//        private static Object ChangeType(object value, Type targetType)
//        {
//            Type convertType = targetType;
//            if (targetType.IsGenericType && targetType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
//            {
//                NullableConverter nullableConverter = new NullableConverter(targetType);
//                convertType = nullableConverter.UnderlyingType;
//            }
//            return Convert.ChangeType(value, convertType);
//        }

//        /// <summary>
//        /// 类型转换
//        /// </summary>
//        /// <typeparam name="T">目标类型</typeparam>
//        /// <param name="convertibleValue">数据</param>
//        /// <returns>返回类型</returns>
//        public static T ConvertTo<T>(this IConvertible convertibleValue)
//        {
//            if (string.IsNullOrEmpty(convertibleValue.ToString()))
//            {
//                return default(T);
//            }
//            if (!typeof(T).IsGenericType)
//            {
//                return (T)Convert.ChangeType(convertibleValue, typeof(T));
//            }
//            else
//            {
//                Type genericTypeDefinition = typeof(T).GetGenericTypeDefinition();
//                if (genericTypeDefinition == typeof(Nullable<>))
//                {
//                    return (T)Convert.ChangeType(convertibleValue, Nullable.GetUnderlyingType(typeof(T)));
//                }
//            }
//            return default(T);
//        }

//        /// <summary>
//        /// Hashtable转换为实体
//        /// </summary>
//        /// <typeparam name="T">实体类</typeparam>
//        /// <param name="t">实体类对象</param>
//        /// <param name="row">Hashtable数据源</param>
//        public static void ConvertHashToEntity<T>(T t, Hashtable row) where T : class
//        {
//            PropertyInfo[] p = typeof(T).GetProperties();

//            foreach (var item in p)
//            {
//                item.SetValue(t, ChangeType(row[item.Name], item.PropertyType), null);
//            }
//        }
//    }
//}
