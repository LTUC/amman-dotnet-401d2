export default function Footer(props) {
    return (
        <div className="px-8 py-4 bg-green-500">
            <p className="text-gray-800">&copy;{props.copyright}</p>
        </div>
    );
}
