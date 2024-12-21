import axios from "axios";

export const fetchHotels = async () => {
  var response = await axios.get("http://localhost:5010/api/hotel");

  return response.data;
};
export const createHotel = async (hotel) => {
  var response = await axios.post("http://localhost:5010/api/hotel", hotel);

  return response.status;
};
