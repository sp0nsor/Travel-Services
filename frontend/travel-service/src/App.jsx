import React from "react";
import HotelSection from "./components/HotelSection";
import BookingForm from "./components/BookingForm";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<HotelSection />} />
        <Route path="/booking" element={<BookingForm />} />
      </Routes>
    </Router>
  );
}

export default App;
