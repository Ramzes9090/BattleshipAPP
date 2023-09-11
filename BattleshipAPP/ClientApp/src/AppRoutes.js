import { Home } from "./components/Home";
import MainPage from "./components/MainPage.js";

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/main-page',
        element: <MainPage/>
    }
];

export default AppRoutes;
