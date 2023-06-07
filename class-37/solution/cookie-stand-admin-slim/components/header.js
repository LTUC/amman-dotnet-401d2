export default function Header(props) {
    return (
        <header className="flex items-center justify-between px-8 py-4 bg-green-500">
            <h1 className="text-4xl">{props.title}</h1>
        </header>
    );
}
