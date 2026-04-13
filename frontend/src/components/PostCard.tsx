import type { Post } from "../types/Post";
import dayjs from "dayjs";

interface Props {
  post: Post;
}

const PostCard = ({ post }: Props) => {
  return (
    <div className="post-card">
      <div className="image-container">
        <img src={post.imageUrl} alt={post.title} />
        <div className="categories">
          {post.categories.slice(0, 2).map((cat, idx) => (
            <span key={idx}>{cat}</span>
          ))}
        </div>
      </div>

      <div className="post-content">
        <h3>{post.title}</h3>
        <p>{post.summary}</p>

        <div className="author-date">
          <span>{post.author}</span>
          <span>|</span>
          <span>{dayjs(post.publishDate).format("DD/MM/YYYY")}</span>
        </div>
      </div>
    </div>
  );
};

export default PostCard;