import React, { useEffect, useState } from "react";
import CreateHotelForm from "./CreateHotelForm";
import Hotel from "./Hotel";
import BookingForm from "./BookingForm";
import RestaurantSection from "./RestaurantSection"; // Импортируем RestaurantSection
import { createHotel, fetchHotels } from "../services/hotel";

function HotelSection() {
  const [hotels, setHotels] = useState([]);
  const [restaurants, setRestaurants] = useState([]); // Состояние для ресторанов

  useEffect(() => {
    const fetchData = async () => {
      let hotels = await fetchHotels();
      setHotels(hotels);
    };
    fetchData();
  }, []);

  const onCreate = async (hotel) => {
    await createHotel(hotel);
    let hotels = await fetchHotels();
    setHotels(hotels);
  };

  return (
    <section className="p-8 flex flex-row justify-start items-start gap-12">
      <div className="flex flex-col w-1/3 gap-10">
        <CreateHotelForm onCreate={onCreate} />
      </div>
      <ul className="flex flex-col gap-5 flex-1">
        {hotels.map((h) => (
          <li key={h.id}>
            <Hotel
              name={h.name}
              description={h.description}
              priceCategory={h.priceCategory}
              city={h.city}
            />
            <BookingForm hotelId={h.id} setRestaurants={setRestaurants} />{" "}
          </li>
        ))}
      </ul>
      <RestaurantSection restaurants={restaurants} />{" "}
    </section>
  );
}

export default HotelSection;
