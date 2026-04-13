import './App.css'
import { BrowserRouter, Routes, Route } from "react-router-dom";
import BlogPage from "./pages/BlogPage";
function App() {

      return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<BlogPage />} />
      </Routes>
    </BrowserRouter>
  );

}

export default App
