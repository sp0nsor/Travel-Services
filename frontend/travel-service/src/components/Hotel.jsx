import {
  Text,
  Button,
  Card,
  CardHeader,
  Heading,
  Divider,
  CardBody,
} from "@chakra-ui/react";
import { useState } from "react";
import BookingForm from "./BookingForm";

export default function Hotel({ id, name, description, priceCategory, city }) {
  const [showBookingForm, setShowBookingForm] = useState(false);

  const onClick = () => {
    setShowBookingForm(!showBookingForm);
  };

  return (
    <Card variant={"filled"}>
      <CardHeader>
        <Heading size={"md"}>Название: {name}</Heading>
      </CardHeader>
      <Divider borderColor={"gray"} />
      <CardBody>
        <Text fontSize="sm">Описание: {description}</Text>
        <Text>Город: {city}</Text>
        <Text>Ценовая категория: {priceCategory}</Text>
        {showBookingForm && <BookingForm hotelId={id} />}{" "}
      </CardBody>
      <Divider borderColor={"gray"} />
    </Card>
  );
}
