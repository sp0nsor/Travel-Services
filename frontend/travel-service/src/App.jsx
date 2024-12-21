import CreateHotelForm from "./components/CreateHotelForm";
import Hotel from "./components/Hotel";
import { useEffect, useState } from "react";
import { createHotel, fetchHotels } from "./services/hotel";

function App() {
  const [hotels, setHotels] = useState([]);

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
        {hotels.map((h) => {
          return (
            <li key={h.id}>
              <Hotel
                name={h.name}
                description={h.description}
                priceCategory={h.priceCategory}
                city={h.city}
              />
            </li>
          );
        })}
      </ul>
    </section>
  );
}

export default App;
