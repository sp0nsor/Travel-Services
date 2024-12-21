import {
  Text,
  Button,
  Card,
  CardHeader,
  Heading,
  Divider,
  CardBody,
} from "@chakra-ui/react";

export default function Restaurant({
  name,
  description,
  priceCategory,
  city,
  address,
  rating,
}) {
  return (
    <Card variant={"filled"}>
      <CardHeader>
        <Heading size={"md"}>Название: {name}</Heading>
      </CardHeader>
      <Divider borderColor={"gray"} />
      <CardBody>
        <Text fontSize="sm">Описаиние: {description}</Text>
        <Text>Город: {city}</Text>
        <Text>Ценовая категория: {priceCategory}</Text>
        <Text>Адрес: {address}</Text>
        <Text>Рейтинг: {rating}</Text>
      </CardBody>
      <Divider borderColor={"gray"} />
    </Card>
  );
}
