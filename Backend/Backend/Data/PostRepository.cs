using Backend.Models;

namespace Backend.Data
{
    public class PostRepository
    {
        private static readonly List<string> AllCategories = new()
        {
            "טכנולוגיה",
            "מדעים",
            "חינוך",
            "חדשנות",
            "קהילה",
            "ספורט",
            "מוזיקה",
            "לשון",
            "פיזיקה",
            "אין פוסטים לקטגוריה זו"
        };

        private static List<Post> _posts = new List<Post>
        {       
        new Post {
            Id=1,
            Title="חדשנות טכנולוגית בכיתה",
            Summary="שילוב כלים מתקדמים בלמידה",
            Content="...",
            Author="משה כהן",
            PublishDate=DateTime.Now.AddDays(-1),
            ImageUrl="https://images.unsplash.com/photo-1518770660439-4636190af475",
            Categories=new []{"טכנולוגיה"}
        },
        new Post {
            Id=2,
            Title="מעבדת מדעים מתקדמת",
            Summary="סביבה חדשנית ללמידה",
            Content="...",
            Author="משה לוי",
            PublishDate=DateTime.Now.AddDays(-2),
            ImageUrl="https://images.unsplash.com/photo-1551288049-bebda4e38f71",
            Categories=new []{"מדעים"}
            },
        new Post {
            Id=3,
            Title="למידה דיגיטלית",
            Summary="עתיד החינוך כבר כאן",
            Content="...",
            Author="אפרים כהן",
            PublishDate=DateTime.Now.AddDays(-3),
            ImageUrl="https://images.unsplash.com/photo-1519389950473-47ba0277781c",
            Categories=new []{"חינוך","טכנולוגיה","חדשנות"}
        },
        new Post {
            Id=4,
            Title="עיצוב סביבת למידה",
            Summary="איך סביבה משפיעה על תלמידים",
            Content="...",
            Author="אלישע דיין",
            PublishDate=DateTime.Now.AddDays(-4),
            ImageUrl="https://images.unsplash.com/photo-1492724441997-5dc865305da7",
            Categories=new []{"חינוך"}
        },
        new Post {
            Id=5,
            Title="שימוש בלוחות חכמים",
            Summary="כלים דיגיטליים מתקדמים",
            Content="...",
            Author="אברהם אברהמי",
            PublishDate=DateTime.Now.AddDays(-5),
            ImageUrl="https://images.unsplash.com/photo-1581092580497-e0d23cbdf1dc",
            Categories=new []{"טכנולוגיה"}
        },


        new Post{
            Id=6,
            Title="עתיד הבינה המלאכותית",
            Summary="סקירה על התקדמות AI והשפעתו על העולם",
            Content="תוכן מלא על בינה מלאכותית...",
            Author="יוסי לוי",
            PublishDate=DateTime.Now.AddDays(-6),
            ImageUrl="https://images.unsplash.com/photo-1559757175-0eb30cd8c063",
            Categories=new string[]{"טכנולוגיה","חדשנות"}
        },
        
        new Post{
            Id=7,
            Title="חקר החלל המודרני",
            Summary="איך מדענים חוקרים כוכבים רחוקים",
            Content="תוכן על חלל...",
            Author="דנה כהן",
            PublishDate=DateTime.Now.AddDays(-7),
            ImageUrl="https://images.unsplash.com/photo-1446776811953-b23d57bd21aa",
            Categories=new string[]{"מדעים","פיזיקה"}
        },
        
        new Post{
            Id=8,
            Title="למידה דיגיטלית בבתי ספר",
            Summary="איך טכנולוגיה משנה את החינוך",
            Content="תוכן על חינוך...",
            Author="רחל ישראלי",
            PublishDate=DateTime.Now.AddDays(-8),
            ImageUrl="https://images.unsplash.com/photo-1509062522246-3755977927d7",
            Categories=new string[]{"חינוך","טכנולוגיה"}
        },
        
        new Post{
            Id=9,
            Title="חדשנות בתחבורה חכמה",
            Summary="רכבים אוטונומיים ועתיד התחבורה",
            Content="תוכן על תחבורה...",
            Author="משה כהן",
            PublishDate=DateTime.Now.AddDays(-9),
            ImageUrl="https://images.unsplash.com/photo-1503376780353-7e6692767b70",
            Categories=new string[]{"חדשנות"}
        },
        
        new Post{
            Id=10,
            Title="קהילות לומדות בישראל",
            Summary="איך קהילה משפיעה על חינוך",
            Content="תוכן קהילתי...",
            Author="שרה לוי",
            PublishDate=DateTime.Now.AddDays(-10),
            ImageUrl="https://images.unsplash.com/photo-1492724441997-5dc865305da7",
            Categories=new string[]{"קהילה","חינוך"}
        },
        
        new Post{
            Id=11,
            Title="מדעי המוח והלמידה",
            Summary="איך המוח לומד מידע חדש",
            Content="תוכן על מוח...",
            Author="אורי כהן",
            PublishDate=DateTime.Now.AddDays(-11),
            ImageUrl="https://images.unsplash.com/photo-1559757175-0eb30cd8c063",
            Categories=new string[]{"מדעים"}
        },
        
        new Post{
            Id=12,
            Title="ספורט וטכנולוגיה",
            Summary="איך טכנולוגיה משפרת ביצועים",
            Content="תוכן על ספורט...",
            Author="דן לוי",
            PublishDate=DateTime.Now.AddDays(-12),
            ImageUrl="https://images.unsplash.com/photo-1517649763962-0c623066013b",
            Categories=new string[]{"ספורט","טכנולוגיה"}
        },
        
        new Post{
            Id=13,
            Title="התפתחות המוזיקה הדיגיטלית",
            Summary="ממוזיקה אנלוגית לסטרימינג",
            Content="תוכן מוזיקה...",
            Author="נועה כהן",
            PublishDate=DateTime.Now.AddDays(-13),
            ImageUrl="https://images.unsplash.com/photo-1511379938547-c1f69419868d",
            Categories=new string[]{"מוזיקה"}
        },
        
        new Post{
            Id=14,
            Title="שפה ותקשורת בעידן הדיגיטלי",
            Summary="איך האינטרנט משנה את השפה",
            Content="תוכן לשוני...",
            Author="יעל לוי",
            PublishDate=DateTime.Now.AddDays(-14),
            ImageUrl="https://images.unsplash.com/photo-1455390582262-044cdead277a",
            Categories=new string[]{"לשון"}
        },
        
        new Post{
            Id=15,
            Title="חוקי הפיזיקה בחיי היומיום",
            Summary="איך פיזיקה משפיעה על העולם סביבנו",
            Content="תוכן פיזיקה...",
            Author="אבי כהן",
            PublishDate=DateTime.Now.AddDays(-15),
            ImageUrl="https://images.unsplash.com/photo-1507413245164-6160d8298b31",
            Categories=new string[]{"פיזיקה"}
        },
        
        new Post{
            Id=16,
            Title="חדשנות בחינוך מרחוק",
            Summary="למידה בזום וכלים דיגיטליים",
            Content="תוכן...",
            Author="מיכל לוי",
            PublishDate=DateTime.Now.AddDays(-16),
            ImageUrl="https://images.unsplash.com/photo-1518779578993-ec3579fee39f",
            Categories=new string[]{"חינוך","חדשנות"}
        },
        
        new Post{
            Id=17,
            Title="קהילות אונליין",
            Summary="איך רשתות מחברות אנשים",
            Content="תוכן...",
            Author="רן כהן",
            PublishDate=DateTime.Now.AddDays(-17),
            ImageUrl="https://images.unsplash.com/photo-1521737604893-d14cc237f11d",
            Categories=new string[]{"קהילה"}
        },
        
        new Post{
            Id=18,
            Title="פיתוח אפליקציות מודרני",
            Summary="כלים וטכנולוגיות עדכניות",
            Content="תוכן...",
            Author="איתי לוי",
            PublishDate=DateTime.Now.AddDays(-18),
            ImageUrl="https://images.unsplash.com/photo-1518779578993-ec3579fee39f",
            Categories=new string[]{"טכנולוגיה"}
        },
        
        new Post{
            Id=19,
            Title="מדעי הנתונים",
            Summary="ניתוח מידע בעידן הדיגיטלי",
            Content="תוכן...",
            Author="שירה כהן",
            PublishDate=DateTime.Now.AddDays(-19),
            ImageUrl="https://images.unsplash.com/photo-1551288049-bebda4e38f71",
            Categories=new string[]{"מדעים","טכנולוגיה"}
        },
        
        new Post{
            Id=20,
            Title="ספורט הישגי",
            Summary="הדרך להצלחה בספורט מקצועי",
            Content="תוכן...",
            Author="גיל לוי",
            PublishDate=DateTime.Now.AddDays(-20),
            ImageUrl="https://images.unsplash.com/photo-1508609349937-5ec4ae374ebf",
            Categories=new string[]{"ספורט"}
        }

    };
        
        public static IEnumerable<Post> GetPosts(string? search = null, string? category = null)
        {
            var query = _posts.AsEnumerable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p =>
                    p.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    p.Summary.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    p.Content.Contains(search, StringComparison.OrdinalIgnoreCase)
                );
            }

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(p => p.Categories.Contains(category, StringComparer.OrdinalIgnoreCase));
            }

            return query.OrderByDescending(p => p.PublishDate);
        }

        public static IEnumerable<string> GetCategories()
        {
            var usedCategories = _posts
                .SelectMany(p => p.Categories)
                .Distinct();

            return AllCategories
                .Where(c => usedCategories.Contains(c))
                .OrderBy(c => c);
        }
    }
}
