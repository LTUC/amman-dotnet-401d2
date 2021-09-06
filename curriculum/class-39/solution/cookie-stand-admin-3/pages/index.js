import { useState } from 'react'
import LoginForm from '../components/login-form'
import CookieStandAdmin from '../components/cookie-stand-admin'
import { getToken, fetcher } from '../services/data-fetcher'

export default function Home() {

    const [token, setToken] = useState();

    const [username, setUsername] = useState('');

    const [hooks, setHooks] = useState();

    async function loginHandler(values) {

        const fetchedToken = await getToken(values);

        setUsername(values.username);

        setHooks(fetcher(fetchedToken));

        setToken(fetchedToken);
    }

    function logoutHandler() {
        setToken(null);
        setHooks(null);
        setUsername('');
    }

    if (!token) return <LoginForm onSubmit={loginHandler} />

    return <CookieStandAdmin
        useCookieStands={hooks.useCookieStands}
        onLogout={logoutHandler}
        username={username}
    />
}


