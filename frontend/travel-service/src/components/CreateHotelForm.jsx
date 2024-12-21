import { Input, Textarea, Select, Button } from "@chakra-ui/react";
import { useState } from "react";

export default function CreateHotelForm({ onCreate }) {
  const [hotel, setHotel] = useState({
    name: "",
    description: "",
    priceCategory: "",
    city: "",
  });

  const onSubmit = (e) => {
    onCreate(hotel);
  };

  return (
    <form onSubmit={onSubmit} className="w-full flex flex-col gap-3">
      <h3 className="font-bold text-xl">Добавление отеля</h3>

      <Input
        placeholder="Name"
        mb={4}
        value={hotel.name}
        onChange={(e) => setHotel({ ...hotel, name: e.target.value })}
      />
      <Textarea
        placeholder="Description"
        mb={4}
        value={hotel.description}
        onChange={(e) => setHotel({ ...hotel, description: e.target.value })}
      />
      <Select
        placeholder="Price Category"
        mb={4}
        value={hotel.priceCategory}
        onChange={(e) => setHotel({ ...hotel, priceCategory: e.target.value })}
      >
        <option value="low">Низкая</option>
        <option value="medium">Средняя</option>
        <option value="high">Высокая</option>
      </Select>
      <Input
        placeholder="City"
        mb={4}
        value={hotel.city}
        onChange={(e) => setHotel({ ...hotel, city: e.target.value })}
      />

      <Button type="submit" colorScheme="teal">
        Добавить отель
      </Button>
    </form>
  );
}
