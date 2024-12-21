import Restaurant from "./Restaurant";

function RestaurantSection({ restaurants }) {
  return (
    <section>
      <ul>
        {restaurants.map((r) => {
          return (
            <li key={Math.random()} className="flex flex-col gap-5 flex-1">
              <Restaurant
                name={r.name}
                description={r.description}
                priceCategory={r.priceCategory}
                city={r.city}
                address={r.address}
                rating={r.rating}
              ></Restaurant>
            </li>
          );
        })}
      </ul>
    </section>
  );
}

export default RestaurantSection;
