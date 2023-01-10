import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import CookieStand from "./components/CookieStand";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
    },
  {
    path: '/cookieStand',
    element: <CookieStand/>
    }
];

export default AppRoutes;
