using Keypath.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keypath.API.MigrationSupport.BaselineData
{
    static public class BaselineExampleItems
    {
        static public List<ExampleItem> GetData()
        {
            return new List<ExampleItem>
            {
                new ExampleItem { Id=1001, Word="The", SortOrder=1 },
                new ExampleItem { Id=1002, Word="rain", SortOrder=2 },
                new ExampleItem { Id=1003, Word="in", SortOrder=3 },
                new ExampleItem { Id=1004, Word="Spain", SortOrder=4 },
                new ExampleItem { Id=1005, Word="falls", SortOrder=5 },
                new ExampleItem { Id=1006, Word="mainly", SortOrder=6 },
                new ExampleItem { Id=1007, Word="on", SortOrder=7 },
                new ExampleItem { Id=1008, Word="the", SortOrder=8 },
                new ExampleItem { Id=1009, Word="plain", SortOrder=9 },
                new ExampleItem { Id=1010, Word="Now ", SortOrder=101 },
                new ExampleItem { Id=1011, Word="is ", SortOrder=102 },
                new ExampleItem { Id=1012, Word="the", SortOrder=103 },
                new ExampleItem { Id=1013, Word="time ", SortOrder=104 },
                new ExampleItem { Id=1014, Word="for", SortOrder=105 },
                new ExampleItem { Id=1015, Word="all", SortOrder=106 },
                new ExampleItem { Id=1016, Word="good", SortOrder=107 },
                new ExampleItem { Id=1017, Word="men", SortOrder=108 },
                new ExampleItem { Id=1018, Word="to ", SortOrder=109 },
                new ExampleItem { Id=1019, Word="come", SortOrder=110 },
                new ExampleItem { Id=1020, Word="to ", SortOrder=111 },
                new ExampleItem { Id=1021, Word="the ", SortOrder=112 },
                new ExampleItem { Id=1022, Word="aid", SortOrder=113 },
                new ExampleItem { Id=1023, Word="of", SortOrder=114 },
                new ExampleItem { Id=1024, Word="their", SortOrder=115 },
                new ExampleItem { Id=1025, Word="country", SortOrder=116 },
                new ExampleItem { Id=1026, Word="The", SortOrder=201 },
                new ExampleItem { Id=1027, Word="quick", SortOrder=202 },
                new ExampleItem { Id=1028, Word="brown", SortOrder=203 },
                new ExampleItem { Id=1029, Word="fox", SortOrder=204 },
                new ExampleItem { Id=1030, Word="jumped", SortOrder=205 },
                new ExampleItem { Id=1031, Word="over", SortOrder=206 },
                new ExampleItem { Id=1032, Word="the", SortOrder=207 },
                new ExampleItem { Id=1033, Word="lazy", SortOrder=208 },
                new ExampleItem { Id=1034, Word="dog", SortOrder=209 },
                new ExampleItem { Id=1035, Word="How", SortOrder=301 },
                new ExampleItem { Id=1036, Word="now ", SortOrder=302 },
                new ExampleItem { Id=1037, Word="brown", SortOrder=303 },
                new ExampleItem { Id=1038, Word="cow", SortOrder=304 }
            };

        }
    }
}
