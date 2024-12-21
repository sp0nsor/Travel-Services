import { Button, Card, CardBody, Input } from "@chakra-ui/react";
import { useState } from "react";
import { createBooking } from "../services/hotel";

export default function BookingForm({ hotelId, setRestaurants }) {
  const [booking, setBooking] = useState({
    hotelId: hotelId,
    date: "",
  });

  const handleDateChange = (event) => {
    setBooking({ ...booking, date: event.target.value });
  };

  const handleSubmit = async () => {
    if (!booking.date) {
      alert("Дата не введена");
      return;
    }
    try {
      const restaurants = await createBooking(booking); // Получаем данные о ресторанах
      setRestaurants(restaurants); // Обновляем состояние ресторанов в родительском компоненте
    } catch (error) {
      console.error("Ошибка при создании бронирования:", error);
    }
  };

  return (
    <Card variant={"filled"}>
      <CardBody>
        <Input
          type="date"
          value={booking.date}
          onChange={handleDateChange}
          placeholder="Выберите дату"
          mb={4}
        />
        <Button colorScheme="blue" onClick={handleSubmit}>
          Забронировать
        </Button>
      </CardBody>
    </Card>
  );
}
