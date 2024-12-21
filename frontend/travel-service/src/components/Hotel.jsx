import {
  Text,
  Button,
  Card,
  CardHeader,
  Heading,
  Divider,
  CardBody,
} from "@chakra-ui/react";

export default function Hotel({ name, description, priceCategory, city }) {
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
      </CardBody>
      <Divider borderColor={"gray"} />
      <Button>Забронировать</Button>
    </Card>
  );
}
