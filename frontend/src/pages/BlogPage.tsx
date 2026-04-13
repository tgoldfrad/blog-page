import { useEffect, useState, useRef } from "react";
import axios from "axios";
import PostCard from "../components/PostCard";
import type { Post } from "../types/Post";

const BlogPage = () => {
  const [posts, setPosts] = useState<Post[]>([]);
  const [categories, setCategories] = useState<string[]>([]);
  const [search, setSearch] = useState("");
  const [debouncedSearch, setDebouncedSearch] = useState("");
  const [category, setCategory] = useState("");
  const [page, setPage] = useState(1);
  const [hasMore, setHasMore] = useState(true);
  const [loading, setLoading] = useState(false);
  const [showSearch, setShowSearch] = useState(false);

  const scrollRef = useRef<HTMLDivElement>(null);
  const pageSize = 9;

  useEffect(() => {
    const timer = setTimeout(() => {
      setDebouncedSearch(search);
    }, 300);
    return () => clearTimeout(timer);
  }, [search]);

  const fetchPosts = async () => {
    try {
      setLoading(true);
      const res = await axios.get<Post[]>("https://blog-page-server-gwhb.onrender.com/api/posts", {
        params: { search: debouncedSearch, category, page, pageSize },
      });
      setPosts((prev) => (page === 1 ? res.data : [...prev, ...res.data]));
      setHasMore(res.data.length === pageSize);
    } catch (err) {
      console.error(err);
    } finally {
      setLoading(false);
    }
  };

  const fetchCategories = async () => {
    try {
      const res = await axios.get<string[]>(
        "https://blog-page-server-gwhb.onrender.com/api/posts/categories"
      );
      setCategories(res.data);
    } catch (err) {
      console.error(err);
    }
  };

  const scroll = (direction: "left" | "right") => {
    if (scrollRef.current) {
      scrollRef.current.scrollBy({
        left: direction === "right" ? -250 : 250,
        behavior: "smooth",
      });
    }
  };

  useEffect(() => {
    fetchCategories();
  }, []);

  useEffect(() => {
    setPage(1);
  }, [debouncedSearch, category]);

  useEffect(() => {
    fetchPosts();
  }, [page, debouncedSearch, category]);

  return (
    <div className="page-container">
      <header className="banner">
        <div className="banner-content">
          <div className="banner-top">| מרכז ידע</div>
          <h1>כתבות, סיפורים ותכנים</h1>
          <h1>מעולם החינוך של רשת עמל</h1>
          <p className="banner-sub">
            תוכן איכותי מעולם החינוך, החדשנות והטכנולוגיה
          </p>
        </div>
      </header>

      <div className="top-bar">
        <div className="top-bar-inner">
          {/* Search Area - Right Side */}
          <div className="search-area">
            <button
              className="search-icon"
              onClick={() => setShowSearch((prev) => !prev)}
              aria-label="חיפוש"
            >
              <svg
                width="20"
                height="20"
                viewBox="0 0 24 24"
                fill="none"
                stroke="currentColor"
                strokeWidth="2.5"
                strokeLinecap="round"
                strokeLinejoin="round"
              >
                <circle cx="11" cy="11" r="8" />
                <line x1="21" y1="21" x2="16.65" y2="16.65" />
              </svg>
            </button>

            {showSearch && (
              <input
                className="search-input"
                placeholder="חיפוש..."
                value={search}
                onChange={(e) => setSearch(e.target.value)}
              />
            )}
          </div>

          {/* Right Arrow */}
          <button
            className="scroll-btn"
            onClick={() => scroll("right")}
            aria-label="גלול ימינה"
          >
            <svg
              width="20"
              height="20"
              viewBox="0 0 24 24"
              fill="none"
              stroke="currentColor"
              strokeWidth="2.5"
              strokeLinecap="round"
              strokeLinejoin="round"
            >
               <polyline points="9 18 15 12 9 6" />
            </svg>
          </button>

          {/* Categories */}
          <div className="categories-bar" ref={scrollRef}>
            <button
              className={!category ? "active" : ""}
              onClick={() => setCategory("")}
            >
              הכל
            </button>

            {categories.map((cat) => (
              <button
                key={cat}
                className={category === cat ? "active" : ""}
                onClick={() => setCategory(cat)}
              >
                {cat}
              </button>
            ))}
          </div>

          {/* Left Arrow */}
          <button
            className="scroll-btn"
            onClick={() => scroll("left")}
            aria-label="גלול שמאלה"
          >
            <svg
              width="20"
              height="20"
              viewBox="0 0 24 24"
              fill="none"
              stroke="currentColor"
              strokeWidth="2.5"
              strokeLinecap="round"
              strokeLinejoin="round"
            >
             
              <polyline points="15 18 9 12 15 6" />
            </svg>
          </button>
        </div>
      </div>

      {loading && <p className="center">טוען...</p>}

      <div className="posts-grid">
        {posts.map((post) => (
          <PostCard key={post.id} post={post} />
        ))}
      </div>

      {!loading && posts.length === 0 && (
        <p className="center">לא נמצאו תוצאות</p>
      )}

      {!loading && posts.length > 0 && hasMore && (
        <div className="load-more-container">
          <button
            className="load-more-btn"
            onClick={() => setPage((prev) => prev + 1)}
          >
            עוד כתבות
          </button>
        </div>
      )}
    </div>
  );
};

export default BlogPage;