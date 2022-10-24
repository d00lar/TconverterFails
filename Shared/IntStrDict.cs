namespace MyApplication.Shared
{
    public class IntStrDict
    {
        public List<KeyValuePair<int, string>> Values { get; set; } = new();



        public string GetVal(int? Key)
        {
            if (Values.Count == 0) return "Loading..";

            try
            {
                return Values.Where(x => x.Key == Key).Single().Value;
            }
            catch (Exception)
            {

                return "NotMappedDictValue";
            }


        }

    }
}
